using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{
    public class MasterCraft : Vehicle, IGasVehicle // Speed Boat with Nitogen System
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;

        }

        public override void Drive()

        {
            Console.WriteLine($"The {MainColor} MasterCraft flies over the water");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"{Name}, the MasterCraft, leans {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, coasts to a stop after smooth stop at the dock.");
        }
    }
}