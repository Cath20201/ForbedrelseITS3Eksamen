using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public class FlexiblePricePayment : IExpenseForPayment
    {
        private double _price;
        private int _hour;
        private int _flexibleprice;
        public double GetPriceBill(MeterDataSample dataSample)
        {
            _hour = dataSample.reportTime.Hour;

            if (0 <= _hour && _hour <= 5)
                _flexibleprice = 145;
            else if (6 <= _hour && _hour <= 9)
                _flexibleprice = 330;
            else if (10 <= _hour && _hour <= 16)
                _flexibleprice = 190;
            else if (17 <= _hour && _hour <= 20)
                _flexibleprice = 435;
            else if (21 <= _hour && _hour <= 23)
                _flexibleprice = 120;
            _price = _flexibleprice * dataSample.customerSpending;

            return _price/100;
        }
    }
}
