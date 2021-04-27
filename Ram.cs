using System;

namespace inheritance
{
  public class Ram : IGasVehicle // Gas powered truck
  {
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public int CurrentTankPercentage { get; set; } = 57;
    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }
    public void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram rolls on by. Poooof!");
    }
    public void Turn()
    {
      Console.WriteLine($"The {MainColor} Ram pops the curb. ");
    }
    public void Stop()
    {
      Console.WriteLine($"The {MainColor} Ram slowly comes to an appropriate stop.");
    }
  }
}