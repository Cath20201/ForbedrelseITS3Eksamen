using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public class FlexiblePricePayment : IExpenseForPayment
    {
        private double _price = 20.4;

        public double GetPriceBill(double priceBill)
        {
            return _price;
        }
    }
}
