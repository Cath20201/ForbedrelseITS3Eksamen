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
        private ConsumptionHistory _consumptionHistory;

        public CustomerBill(Customer customer, IDisplay display,
            ConsumptionHistory consumptionHistory, IHistory history)
        {
            _display = display;
            _history = history;
            _customer = customer;
            _consumptionHistory = consumptionHistory;
        }

        public double CalculateBill()
        {
            double bill = 0;

            List<MeterDataSample> CalculateBillList = _history.GetHistory();

            if (_customer.GetKontrakttype() == "FixedPrice payment")
            {
                foreach (MeterDataSample BillFlixed in CalculateBillList)
                {
                    _display.printCalculateBill(BillFlixed.Price);
                }
            }
            else if (_customer.GetKontrakttype() == "FlexiblePrice payment")
            {
                
            }

            return bill;
        }
    }
}
