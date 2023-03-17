using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary.CustomerInfo
{
    public class Customer
    {
        public int Kundenummer { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Kontrakttype { get; set; }
        public int Lokationsid { get; set; }

        public Customer(int kundenummer, string navn, string adresse, string kontrakttype, int lokationsid )
        {
            Kundenummer = kundenummer;
            Navn = navn;
            Adresse = adresse;
            Kontrakttype = kontrakttype;
            Lokationsid = lokationsid;
        }



    }
}
