using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle Turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Zoooooom!, Then the vehicle gradually slows to a stop.");
        }
    }

}