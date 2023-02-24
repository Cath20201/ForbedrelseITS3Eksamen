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
        public double customerSpending;
        public double Price { get; set; }


        public MeterDataSample(int customerID, DateTime reportTime, double customerSpending)
        {
            this.customerID = customerID;
            this.reportTime = reportTime;
            this.customerSpending = customerSpending;
        }
    }
}
