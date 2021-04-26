using System;

namespace inheritance
{
  public class Vehicle
  {
    public virtual string MainColor { get; set; }
    public virtual string MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
      Console.WriteLine("Vrooom!");
    }
    
    public virtual void Turn()
    {
      Console.WriteLine("Vrooom!");
    }
    
    public virtual void Stop()
    {
      Console.WriteLine("Vrooom!");
    }
  }
}