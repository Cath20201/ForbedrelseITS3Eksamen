using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public class ConsumptionHistory : IHistory
    {
        private List<IHistory> _historyList;

        public ConsumptionHistory(List<IHistory> historyList)
        {
            _historyList = new List<IHistory>();
        }

        public void AddToHistoryList()
        {
            _historyList.Add();

        }
        public void PrintHistory(List<MeterDataSample> Historylist)
        {
            
        }
    }
}
