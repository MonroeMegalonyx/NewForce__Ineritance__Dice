using System;

namespace inheritance
{
  public class Cessna : Vehicle // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public override string MainColor { get; set; }
    public override string MaximumOccupancy { get; set; }

    public void RefuelTank()
    {
      // method definition omitted
    }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} flies by at the speed of light. Zoooooom!");
    }
    public override void Turn()
    {
      Console.WriteLine($"The {MainColor} Cessna does a barrel roll. Wow! ");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Cessna suddenly stops and beings to plummet. Weeeeeeee! ");
    }
  }
}