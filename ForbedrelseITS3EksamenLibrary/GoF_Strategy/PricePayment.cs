using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbedrelseITS3EksamenLibrary.GoF_Observer;

namespace ForbedrelseITS3EksamenLibrary.GoF_Strategy
{
    public class PricePayment : IDataObserver
    {
        private readonly MeterdataMontior _meterdataMontior;
        public IExpenseForPayment PricePaymentType { get; set; }

        public PricePayment(MeterdataMontior meterdataMontior)
        {
            meterdataMontior.Attach(this);
            _meterdataMontior = meterdataMontior;


        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
