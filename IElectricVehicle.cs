using System;

namespace GarysGarage
{

    public interface IElectricVehicle
    {

        int CurrentChargePercentage { get; set; }
        void ChargeBattery();
    }

}