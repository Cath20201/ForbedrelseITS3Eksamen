using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbedrelseITS3EksamenLibrary.GoF_Observer;

namespace ForbedrelseITS3EksamenLibrary.CustomerInfo
{
    public class CustomerBill : ICustomerBill
    {
        private Customer _customer;
        private IDisplay _display;
        private IHistory _history;
        

        public CustomerBill(Customer customer, IDisplay display, IHistory history)
        {
            _display = display;
            _history = history;
            _customer = customer;
        }

        public double CalculateBill(Customer customer)
        {
            double bill = 0;

            List<MeterDataSample> CalculateBillList = _history.GetHistory();

            

            return bill;
        }
    }
}
