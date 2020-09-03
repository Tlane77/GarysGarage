using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public override void Drive()

        {
            Console.WriteLine($"The {MainColor} Cessna flies over - Metro Nashville");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Cessna, banks {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, rolls to a stop after rolling a mile down the runway.");
        }
    }
}