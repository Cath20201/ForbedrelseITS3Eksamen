using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public class FixedPricePayment : IExpenseForPayment
    {
        private double _fixedPrice = 42.4;
        public double GetPriceBill(double priceBill)
        {
            return _fixedPrice;
        }
    }
}
