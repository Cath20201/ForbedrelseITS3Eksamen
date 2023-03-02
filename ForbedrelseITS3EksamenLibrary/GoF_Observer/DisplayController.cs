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
        public DisplayController(MeterdataMonitor monitor, IDisplay display, IHistory _history)
        {
            _display = display;
            _monitor = monitor;
            _history = new ConsumptionHistory();
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

        public void PrintSaveData()
        {
            List<MeterDataSample> list = _history.GetHistory();

            foreach (MeterDataSample recordDataSample in list)
            {
                _display.print(recordDataSample.customerID, recordDataSample.reportTime, recordDataSample.customerSpending, recordDataSample.Price);
            }
        }
    }
}
