using ForbedrelseITS3EksamenLibrary.CustomerInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.GoF_Observer
{
    public class InfoDisplay : IDisplay
    {
        private Customer _customer;

        public InfoDisplay(Customer customer)
        {
            _customer = customer;
        }
        public void print(int customerID, DateTime reportTime, double cusspending, double pricebill)
        {
            Console.WriteLine("ID: " + customerID + " Tid: " + reportTime + " El forbrug: " + cusspending);
            Console.WriteLine("Prisen er: {0:0.000} kr",pricebill);
        }

        public void printCalculateBill(double CustomerCalculateBill)
        {
            Console.WriteLine("Regning: {0:0.000} kr",CustomerCalculateBill);
        }
        public void CustomerInformation()
        {
            Console.WriteLine("Kundenummer: {0}", _customer.Kundenummer);
            Console.WriteLine("Navn: {0}", _customer.Navn);
            Console.WriteLine("Adresse: {0}", _customer.Adresse);
            Console.WriteLine("Kontrakttype: {0}", _customer.Kontrakttype);
            Console.WriteLine("Lokations ID: {0}", _customer.Lokationsid);
            Console.WriteLine("**************************************");
        }
    }
}
