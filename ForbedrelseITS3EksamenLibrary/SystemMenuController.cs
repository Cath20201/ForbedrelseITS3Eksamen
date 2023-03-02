﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbedrelseITS3EksamenLibrary.GoF_Observer;
using ForbedrelseITS3EksamenLibrary.GoF_Strategy;

namespace ForbedrelseITS3EksamenLibrary
{
    
    public class SystemMenuController
    {
        private readonly BlockingCollection<MeterDataSample> DataQueue;
        private readonly ElectricityMeterControl DataProducer;
        private readonly MeterdataMonitor DataConsumer;

        private List<IElectricityMeters> _electricityMetersList;
        private IElectricityMeters electricityMeters;

        private List<MeterDataSample> histories;
        private IDisplay display;
        private IHistory _history;

        private DisplayController displayController;

        public SystemMenuController()
        {
            electricityMeters = new ElectricityMeters(1);

            _electricityMetersList = new List<IElectricityMeters>();
            _electricityMetersList.Add(electricityMeters);

            DataQueue = new BlockingCollection<MeterDataSample>();
            DataProducer = new ElectricityMeterControl(DataQueue, _electricityMetersList);
            DataConsumer = new MeterdataMonitor(DataQueue, _history);

            _history = new ConsumptionHistory();

            display = new InfoDisplay();
            displayController = new DisplayController(DataConsumer, display, _history);
            

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

        public void SetPrice(string type)
        {
            if (type == "FixedPrice payment")
                DataConsumer._ExpenseForPayment = new FixedPricePayment();
            if (type == "FlexiblePrice payment")
                DataConsumer._ExpenseForPayment = new FlexiblePricePayment();
        }

        public void PrintHisData()
        {
            displayController.PrintSaveData();
        }
    }
    
}
