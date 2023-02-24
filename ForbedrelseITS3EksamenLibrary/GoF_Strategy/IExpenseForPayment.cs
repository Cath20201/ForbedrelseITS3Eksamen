using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public interface IExpenseForPayment
    {
        public double GetPriceBill(MeterDataSample dataSample);
    }
}
