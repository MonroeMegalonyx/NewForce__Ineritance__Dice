using System;

namespace inheritance
{
  public class Zero : IElectricVehicle  // Electric motorcycle
  {
    public double BatteryKWh { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public int CurrentChargePercentage { get; set; } = 10;
    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }
    public void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero zips by. Swooooosh! ");
    }
    public void Turn()
    {
      Console.WriteLine($"The {MainColor} Zero barely make the turn. Phew! ");
    }
    public void Stop()
    {
      Console.WriteLine($"The {MainColor} Zero screeches to a halt. DAMMMMMMN! ");
    }
  }
}