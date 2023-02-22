using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public class MeterDataSample
    {
        public int customerID;
        public DateTime reportTime;

        public MeterDataSample(int customerID, DateTime reportTime)
        {
            this.customerID = customerID;
            this.reportTime = reportTime;
        }
    }
}
