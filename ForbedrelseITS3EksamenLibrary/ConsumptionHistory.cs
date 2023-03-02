using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public class ConsumptionHistory : IHistory
    {
        private List<MeterDataSample> _historyList;

        public ConsumptionHistory()
        {
            _historyList = new List<MeterDataSample>();
        }

        public void AddToHistoryList(MeterDataSample dataSample)
        {
            _historyList.Add(dataSample);

        }
        public List<MeterDataSample> GetHistory()
        {
            return _historyList;
        }

    }
}
