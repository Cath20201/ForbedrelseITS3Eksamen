using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    // Consumer
    public class MeterdataMontior
    {
        private BlockingCollection<MeterDataSample> _queue;

        public bool PrintData { get; set; } = false;
        public bool notStopped { get; set; } = true;
        public MeterDataSample MeterDataSample { get; set; }

        public MeterdataMontior(BlockingCollection<MeterDataSample> queue)
        {
            _queue = queue;
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
                            Console.WriteLine("ID: " + MeterDataSample.customerID + " Tid: " + MeterDataSample.reportTime + " Elforbrug: " + MeterDataSample.customerSpending);
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
