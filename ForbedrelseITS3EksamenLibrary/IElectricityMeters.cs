using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbedrelseITS3EksamenLibrary
{
    public interface IElectricityMeters
    {
        public int ID { get; set; }
        public double Forbrug { get; set; }
        public DateTime Time { get; set; }
        public double Price { get; set; }
        public double GetkiloWatt();
    }
}
