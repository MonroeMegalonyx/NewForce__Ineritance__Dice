using System;

namespace inheritance
{
  public class Tesla : IElectricVehicle  // Electric car
  {
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public int CurrentChargePercentage { get; set; } = 27;
    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
    public void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla is burning on the side of the road. Whoomp whoooomp");
    }
    public void Turn()
    {
      Console.WriteLine($"The {MainColor} Tesla tries to turn before the intersection.");
    }
    public void Stop()
    {
      Console.WriteLine($"The {MainColor} Tesla is in autopilot and can't stop.");
    }
  }
}