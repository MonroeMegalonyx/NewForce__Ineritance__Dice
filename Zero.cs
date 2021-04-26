using System;

namespace inheritance
{
  public class Zero : Vehicle  // Electric motorcycle
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
      Console.WriteLine($"The {MainColor} Zero zips by. Swooooosh! ");
    }
    public override void Turn()
    {
      Console.WriteLine($"The {MainColor} Zero barely make the turn. Phew! ");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Zero screeches to a halt. DAMMMMMMN! ");
    }
  }
}