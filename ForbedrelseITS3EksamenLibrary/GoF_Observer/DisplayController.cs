using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbedrelseITS3EksamenLibrary.CustomerInfo;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class DisplayController : IDataObserver
    {
        private readonly MeterdataMonitor _monitor;

        private Customer _customer;

        private IDisplay _display;
        private IHistory _history;
        public DisplayController(MeterdataMonitor monitor, IDisplay display, IHistory history)
        {
            _display = display;
            _monitor = monitor;
            _history = history;
            monitor.Attach(this);
            
            _customer = new Customer(1234, "Peter Jensen", "Lærkevej 10", "Fastpris", 98757);
        }

        public void Update()
        {
            if (_monitor.PrintData)
            {
                _display.print(_monitor.MeterDataSample.customerID, 
                    _monitor.MeterDataSample.reportTime, _monitor.MeterDataSample.customerSpending, 
                    _monitor.MeterDataSample.Price);
            }
        }

        public void PrintSaveData()
        {
            List<MeterDataSample> list = _history.GetHistory();

            
            CustomerInformation();

            foreach (MeterDataSample recordDataSample in list)
            {
                _display.print(recordDataSample.customerID, recordDataSample.reportTime, recordDataSample.customerSpending, recordDataSample.Price);
            }
        }

        public void CustomerInformation()
        {
            Console.WriteLine("Kundenummer: {0}", _customer.Kundenummer);
            Console.WriteLine("Navn: {0}", _customer.Navn);
            Console.WriteLine("Adresse: {0}", _customer.Adresse);
            Console.WriteLine("Kontrakttype: {0}", _customer.Kontrakttype);
            Console.WriteLine("Lokations ID: {0}", _customer.Lokationsid);
        }
    }
}
