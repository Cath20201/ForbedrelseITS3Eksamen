using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public class SystemMenuController
    {
        private readonly BlockingCollection<MeterDataSample> DataQueue;
        private readonly ElectricityMeterControl DataProducer;
        private readonly MeterdataMontior DataConsumer;
        private List<IElectricityMeters> ElectricityList;

        public SystemMenuController()
        {
            ElectricityList = new List<IElectricityMeters>();
            DataQueue = new BlockingCollection<MeterDataSample>();
            DataProducer = new ElectricityMeterControl(DataQueue, ElectricityList);
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
    }
    
}
