using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public class FixedPricePayment : IExpenseForPayment
    {
        private double _price;
        private int _FixedPrice = 358; // øre
        public double GetPriceBill(MeterDataSample dataSample)
        {
            _price = _FixedPrice * dataSample.customerSpending;
            
            return _price/100; // får beløbet ud i kr.
        }
    }
}
