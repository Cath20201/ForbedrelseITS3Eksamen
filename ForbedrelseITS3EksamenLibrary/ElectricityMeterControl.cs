using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    // Producer 
    public class ElectricityMeterControl
    {
        private int waitTime { get; } = 1000; 
        private BlockingCollection<MeterDataSample> _queue;
        private readonly List<IElectricityMeters> _electricityMetersList;
        private bool notStopped = true;
        private DateTime dateTime = DateTime.MinValue;
        

        public ElectricityMeterControl(BlockingCollection<MeterDataSample> queue, List<IElectricityMeters> electricityMetersList)
        {
            _queue = queue;
            _electricityMetersList = electricityMetersList;
        }

        public void Run()
        {
            while (notStopped)
            {
                foreach (IElectricityMeters e in _electricityMetersList)
                {
                    double elSpending = e.GetkiloWatt();
                    MeterDataSample meterDataSample = new MeterDataSample(e.ID, dateTime, elSpending);

                    _queue.Add(meterDataSample);
                }
                Thread.Sleep(waitTime);
                dateTime = dateTime.AddMinutes(15);
            }
            _queue.CompleteAdding();
            Console.WriteLine("Producer stopping.....");
        }

        public void Stop()
        {
            notStopped = false;
        }
    }
}
