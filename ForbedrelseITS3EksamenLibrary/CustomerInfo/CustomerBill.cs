using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.CustomerInfo
{
    public class CustomerBill
    {
        private Customer _customer;

        public CustomerBill(Customer customer)
        {
            _customer = customer;
        }

        public double CalculateBill()
        {
            double bill = 0;

            //if (_customer.GetKontrakttype() == "FixedPrice payment")
            //{
                
            //}
            //else if (_customer.GetKontrakttype() == "FlexiblePrice payment")
            //{
                
            //}

            return bill;
        }
    }
}
