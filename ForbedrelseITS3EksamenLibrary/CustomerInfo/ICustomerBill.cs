﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.CustomerInfo
{
    public interface ICustomerBill
    {
        public double CalculateBill(Customer customer);
    }
}
