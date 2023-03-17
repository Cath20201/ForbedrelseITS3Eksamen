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
        private InfoDisplay _infoDisplay;
        private CustomerBill _customerBill;
        private ConsumptionHistory _consumptionHistory;

        private IDisplay _display;
        private IHistory _history;
        public DisplayController(MeterdataMonitor monitor, IDisplay display, IHistory history, Customer customer)
        {
            _display = display;
            _monitor = monitor;
            _history = history;
            _customer = customer;
            monitor.Attach(this);
            _infoDisplay = new InfoDisplay(_customer);

            _customerBill = new CustomerBill(_customer, _display, _history);


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

            
            _infoDisplay.CustomerInformation();

            foreach (MeterDataSample recordDataSample in list)
            {
                _display.print(recordDataSample.customerID, recordDataSample.reportTime, recordDataSample.customerSpending, recordDataSample.Price);
            }
        }

        public void PrintShowBill()
        {
            _display.printCalculateBill(_customerBill.CalculateBill( _customer));
        }

        
    }
}
