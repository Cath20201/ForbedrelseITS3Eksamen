using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public class ElectricityMeterControl
    {
        private BlockingCollection<MeterDataSample> _queue;
        private readonly List<IElectricityMeters> _electricityMetersList;

        public ElectricityMeterControl(BlockingCollection<MeterDataSample> queue, List<IElectricityMeters> electricityMetersList)
        {
            _queue = queue;
            _electricityMetersList = electricityMetersList;
        }
    }
}
