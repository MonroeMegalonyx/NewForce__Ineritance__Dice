using System;

namespace inheritance
{
  public interface IGasVehicle
  {
   double FuelCapacity { get; }
   int CurrentTankPercentage { get; }

   void RefuelTank();

  }
}