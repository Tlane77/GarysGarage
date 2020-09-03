using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{

    public class Titan : Vehicle // Gas Powered Truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The {MainColor} Titan is now has a full tank.");

        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Titan just WOOOOOSHED by me ");

        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the Titan sounds like thunder when it turns {direction}");
        }
    }
}