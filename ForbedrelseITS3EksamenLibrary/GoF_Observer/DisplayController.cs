using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class DisplayController : IDataObserver
    {
        private readonly MeterdataMontior _monitor;
        private IDisplay _display;
        public DisplayController(MeterdataMontior montior, IDisplay display)
        {
            _display = display;
            _monitor = montior;
            montior.Attach(this);
        }

        public void Update()
        {
            if (_monitor.PrintData)
            {
                _display.print(_monitor.MeterDataSample.customerID, _monitor.MeterDataSample.reportTime, _monitor.MeterDataSample.customerSpending, _monitor.MeterDataSample.Price);
            }
        }
    }
}
