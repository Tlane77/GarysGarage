using System;

namespace GarysGarage
{

    public interface IGasVehicle
    {

        int CurrentTankPercentage { get; set; }
        void RefuelTank();
    }

}