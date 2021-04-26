using System;

namespace inheritance
{
  public class Tesla : Vehicle  // Electric car
  {
    public double BatteryKWh { get; set; }
    public override string MainColor { get; set; }
    public override string MaximumOccupancy { get; set; }

    public void ChargeBattery()
    {
      // method definition omitted
    }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla is burning on the side of the road. Whoomp whoooomp");
    }
    public override void Turn()
    {
      Console.WriteLine($"The {MainColor} Tesla tries to turn before the intersection.");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Tesla is in autopilot and can't stop.");
    }
  }
}