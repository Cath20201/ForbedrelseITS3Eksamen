using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.CustomerInfo
{
    public class CustomerBill : ICustomerBill
    {
        private Customer _customer;
        private ConsumptionHistory _consumptionHistory;

        public CustomerBill(Customer customer, ConsumptionHistory consumptionHistory)
        {
            _customer = customer;
            _consumptionHistory = consumptionHistory;
        }

        public double CalculateBill()
        {
            double bill = 0;

            //if (_customer.GetKontrakttype() == "FixedPrice payment")
            //{
            //    while ()
            //    {
            //        // Liste hvor de beregnet priser bliver lagt i
            //    }
            //}
            //else if (_customer.GetKontrakttype() == "FlexiblePrice payment")
            //{
            //    while ()
            //    {
            //        // Liste hvor de beregnet priser bliver lagt i
            //    }
            //}

            return bill;
        }
    }
}
