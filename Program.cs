using System;
using System.Collections.Generic;
using System.Linq;

namespace GarysGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla ModelX = new Tesla();
            ModelX.Name = "ModelX";
            ModelX.MainColor = "Midnight Blue";
            ModelX.Weight = 5531;
            ModelX.BatteryKWh = 100;
            ModelX.Drive();
            ModelX.Turn("right");
            ModelX.Stop();

            Console.WriteLine("---------------------------------");

            Titan PlatinumXD = new Titan();
            PlatinumXD.Name = "PlatinumXD";
            PlatinumXD.MainColor = "Titanium Silver";
            PlatinumXD.Weight = 6700;
            PlatinumXD.RefuelTank();
            PlatinumXD.Drive();
            PlatinumXD.Turn("right");
            PlatinumXD.Stop();

            Console.WriteLine("---------------------------------");

            Cessna Citation = new Cessna();
            Citation.Name = "Citation";
            Citation.Weight = 31000;
            Citation.MainColor = "White";
            Citation.Drive();
            Citation.Turn("left");
            Citation.Stop();

            Console.WriteLine("------------------------");

            MasterCraft NXT22 = new MasterCraft();
            NXT22.Name = "NXT22";
            NXT22.Weight = 4300;
            NXT22.MainColor = "White";
            NXT22.Drive();
            NXT22.Turn("left");
            NXT22.Stop();

            Console.WriteLine("------------------------");

            // Drive(NXT22);
            // Drive(Citation);
            // Drive(PlatinumXD);
            // Drive(ModelX);

        }
    }
}