namespace ForbedrelseITS3EksamenLibrary
{
    public class ElectricityMeters : IElectricityMeters
    {
        public int ID { get; set; }
        public double Forbrug { get; set; }
        public DateTime Time { get; set; }

        public ElectricityMeters(int iD, double forbrug, DateTime time)
        {
            ID = iD;
            Forbrug = forbrug;
            Time = time;
        }
    }
}