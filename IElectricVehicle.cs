using System;

namespace inheritance
{
  public interface IElectricVehicle
  {
    double BatteryKWh { get; }
    public int CurrentChargePercentage { get; }

    void ChargeBattery();

  }
}