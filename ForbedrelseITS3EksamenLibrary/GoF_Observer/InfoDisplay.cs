using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class InfoDisplay : IDisplay
    {
        public void print(int customerID, DateTime reportTime, double cusspending)
        {
            Console.WriteLine("ID: " + customerID + " Tid: " + reportTime + " El forbrug: " + cusspending);
        }
    }
}
