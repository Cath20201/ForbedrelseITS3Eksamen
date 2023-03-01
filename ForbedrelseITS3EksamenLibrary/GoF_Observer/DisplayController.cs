using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class DisplayController : IDataObserver
    {
        private readonly MeterdataMonitor _monitor;
        private IDisplay _display;
        private IHistory _history;
        public DisplayController(MeterdataMonitor monitor, IDisplay display)
        {
            _display = display;
            _monitor = monitor;
            monitor.Attach(this);
            
        }

        public void Update()
        {
            if (_monitor.PrintData)
            {
                _display.print(_monitor.MeterDataSample.customerID, 
                    _monitor.MeterDataSample.reportTime, _monitor.MeterDataSample.customerSpending, 
                    _monitor.MeterDataSample.Price);
            }
        }

        public void PrintSaveData(List<MeterDataSample> Historylist)
        {
            _history.PrintHistory(Historylist);
        }
    }
}
