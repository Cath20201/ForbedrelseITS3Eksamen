using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbedrelseITS3EksamenLibrary.GoF_Observer;
using ForbedrelseITS3EksamenLibrary.GoF_Strategy;

namespace ForbedrelseITS3EksamenLibrary
{
    // Consumer
    public class MeterdataMonitor : MonitorSubejct
    {
        private BlockingCollection<MeterDataSample> _queue;
        public ConsumptionHistory consumptionHistory { get; set; }

        public bool PrintData { get; set; } = false;
        public bool notStopped { get; set; } = true;
        public MeterDataSample MeterDataSample { get; set; }
        public IExpenseForPayment _ExpenseForPayment { get; set; }
        public IHistory _history { get; set; }


        public MeterdataMonitor(BlockingCollection<MeterDataSample> queue, IHistory history)
        {
            _queue = queue;
            _history = history; 
            _ExpenseForPayment = new FixedPricePayment();

        }

        public void Run()
        {
            while (notStopped)
            {
                while (PrintData)
                {
                    if (!_queue.IsCompleted)
                    {
                        try
                        {
                            MeterDataSample = _queue.Take();

                            MeterDataSample.Price = _ExpenseForPayment.GetPriceBill(MeterDataSample);

                            _history.AddToHistoryList(MeterDataSample);

                            Notify();
                            //Console.WriteLine("ID: " + MeterDataSample.customerID + " Tid: " + MeterDataSample.reportTime + " Elforbrug: " + MeterDataSample.customerSpending);
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("Called take from queue that is completed");
                        }
                    }
                }
            }
            Console.WriteLine("DataConsumer stopping....");
        }

        public void Stop()
        {
            notStopped = false;
        }

    }
}
