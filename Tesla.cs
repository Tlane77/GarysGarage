using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{

    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;

        }

        public override void Drive()

        {
            Console.WriteLine($"The {MainColor} Tesla drives by - ZOOOOOOOOM!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($" The {Name}, turns smoothly {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($" The {Name}, has an air filtration system that is on non stop.");
        }
    }
}