﻿namespace ForbedrelseITS3EksamenLibrary
{
    public class ElectricityMeters : IElectricityMeters
    {
        private readonly Random random = new Random();
        private int randomNb;
        public int ID { get; set; }
        public double Forbrug { get; set; }
        public DateTime Time { get; set; }
        


        public ElectricityMeters(int iD)
        {
            ID = iD;
        }
        public double GetkiloWatt()
        {
            randomNb = random.Next(5, 40);
            return randomNb / 100.0;
        }
    }
}