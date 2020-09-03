using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{

    public class Titan : Vehicle, IGasVehicle // Gas Powered Truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;

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