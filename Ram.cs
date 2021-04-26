using System;

namespace inheritance
{
  public class Ram : Vehicle // Gas powered truck
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
      Console.WriteLine($"The {MainColor} Ram rolls on by. Poooof!");
    }
    public override void Turn()
    {
      Console.WriteLine($"The {MainColor} Ram pops the curb. ");
    }
    public override void Stop()
    {
      Console.WriteLine($"The {MainColor} Ram slowly comes to an appropriate stop.");
    }
  }
}