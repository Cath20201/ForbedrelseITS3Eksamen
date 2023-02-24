using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class InfoDisplay : IDisplay
    {
        public void print(int customerID, DateTime reportTime, double cusspending, double pricebill)
        {
            Console.WriteLine("ID: " + customerID + " Tid: " + reportTime + " El forbrug: " + cusspending);
            Console.WriteLine("Prisen er: {0:0.000} kr",pricebill);
        }
    }
}
