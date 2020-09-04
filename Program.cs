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

            Zero ModelFXS = new Zero();
            ModelFXS.Name = "ModelFXS";
            ModelFXS.MainColor = "Cobalt Blue";
            ModelFXS.Weight = 831;
            ModelFXS.BatteryKWh = 100;
            ModelFXS.Drive();
            ModelFXS.Turn("right");
            ModelFXS.Stop();

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

            NXT22.Drive();
            Citation.Drive();
            PlatinumXD.Drive();
            ModelX.Drive();
            ModelFXS.Drive();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                ModelX,
                ModelFXS,

            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}"); //Checking Current Charge
            }

            foreach (IElectricVehicle ev in electricVehicles) //Charging Battery 
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles) //Checking to make sure it's fully charged.
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                PlatinumXD,
                Citation,
                NXT22

            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"I currently have{gv.CurrentTankPercentage}percent in my tank"); //Checking the Percentage of Gas
            }

            foreach (IGasVehicle gv in gasVehicles) //Fueling the GasTank
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles) ///ReChecking to Make Sure the Gas tank is Full.
            {
                Console.WriteLine($"I used all my Kroger Points on {gv.CurrentTankPercentage}percent tank of gas!");
            }

        }
    }
}