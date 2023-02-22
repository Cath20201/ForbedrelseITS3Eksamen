namespace ForbedrelseITS3EksamenLibrary
{
    public class ElectricityMeters : IElectricityMeters
    {
        private readonly Random random = new Random();
        private int randomNb;
        public int ID { get; set; }
        public double Forbrug { get; set; }
        public DateTime Time { get; set; }


        public ElectricityMeters(int iD, double forbrug, DateTime time)
        {
            ID = iD;
            Forbrug = forbrug;
            Time = time;
        }
        public double GetkiloWatt()
        {
            randomNb = random.Next(5, 40);
            return randomNb / 100.0;
        }
    }
}