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

        public SystemMenuController()
        {
            DataQueue = new BlockingCollection<MeterDataSample>();
            
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
