using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    //Hej med dig 
    public class SystemMenuController
    {
        private readonly BlockingCollection<MeterDataSample> DataQueue;
        private readonly ElectricityMeterControl DataProducer;
        private readonly MeterdataMontior DataConsumer;

        private List<IElectricityMeters> _electricityMetersList;
        private IElectricityMeters electricityMeters;


        public SystemMenuController()
        {
            electricityMeters = new ElectricityMeters(1);

            _electricityMetersList = new List<IElectricityMeters>();
            _electricityMetersList.Add(electricityMeters);

            DataQueue = new BlockingCollection<MeterDataSample>();
            DataProducer = new ElectricityMeterControl(DataQueue, _electricityMetersList);
            DataConsumer = new MeterdataMontior(DataQueue);

        }
        
        public void Start()
        {
            Thread producer = new Thread(DataProducer.Run);
            Thread consumer = new Thread(DataConsumer.Run);

            producer.Start();
            consumer.Start();
        }
        public void Startprint()
        {
            DataConsumer.PrintData = true;
            
        }
        public void Stopprint()
        {
            DataConsumer.PrintData = false;
        }

        public void Stop()
        {
            DataProducer.Stop();
            DataConsumer.Stop();
        }
    }
    
}
