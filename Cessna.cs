using System;

namespace inheritance
{
  public class Cessna : IGasVehicle // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public string MainColor { get; set; }
    public string MaximumOccupancy { get; set; }

    public int CurrentTankPercentage { get; set; } = 43;
    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }
    public void Drive()
    {
      Console.WriteLine($"The {MainColor} flies by at the speed of light. Zoooooom!");
    }
    public void Turn()
    {
      Console.WriteLine($"The {MainColor} Cessna does a barrel roll. Wow! ");
    }
    public void Stop()
    {
      Console.WriteLine($"The {MainColor} Cessna suddenly stops and beings to plummet. Weeeeeeee! ");
    }
  }
}