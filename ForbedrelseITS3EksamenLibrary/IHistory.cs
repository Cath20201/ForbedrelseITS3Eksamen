using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public interface IHistory
    {
        public List<MeterDataSample> GetHistory();
        public void AddToHistoryList(MeterDataSample dataSample);
    }
}
