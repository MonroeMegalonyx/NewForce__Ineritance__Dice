using System;

namespace inheritance
{
  public interface IGasVehicle
  {
    public double FuelCapacity { get; }
    public int CurrentTankPercentage { get; }

    public void RefuelTank();

  }
}