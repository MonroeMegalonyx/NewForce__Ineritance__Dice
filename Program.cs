using System;
using System.Collections.Generic;

namespace inheritance
{
  // class Program
  // {
  //   static void Main(string[] args)
  //   {
  //     Zero fxs = new Zero()
  //     {
  //       MainColor = "Blue",
  //     };
  //     Zero fx = new Zero()
  //     {
  //       MainColor = "Red",
  //     };
  //     Tesla modelS = new Tesla()
  //     {
  //       MainColor = "Black",
  //     };
  //     Cessna mx410 = new Cessna()
  //     {
  //       MainColor = "Yellow",
  //     };

  //     //List<Zero> electricVehicles = new List<Zero>() { fx, fxs };

  //     fxs.Drive();
  //     fxs.Turn();
  //     fxs.Stop();
  //     fx.Drive();
  //     fx.Turn();
  //     fx.Stop();
  //     modelS.Drive();
  //     modelS.Turn();
  //     modelS.Stop();
  //     mx410.Drive();
  //     mx410.Turn();
  //     mx410.Stop();
  //   }
  // }
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      List<IElectricVehicle> electricVehicles = new List<IElectricVehicle> () {
        fx, fxs, modelS
            };

      Console.WriteLine("Electric Vehicles");
      foreach (IElectricVehicle ev in electricVehicles)
      {
        Console.WriteLine($"The car is at {ev.CurrentChargePercentage}%");
      }

      foreach (IElectricVehicle ev in electricVehicles)
      {
        // This should charge the vehicle to 100%
        ev.ChargeBattery();
      }

      foreach (IElectricVehicle ev in electricVehicles)
      {
        Console.WriteLine($"Now the car is at {ev.CurrentChargePercentage}%");
      }

      /***********************************************/

      Ram ram = new Ram();
      Cessna cessna150 = new Cessna();

      List <IGasVehicle> gasVehicles = new List<IGasVehicle> () {
        ram, cessna150
            };

      Console.WriteLine("Gas Vehicles");
      foreach (IGasVehicle gv in gasVehicles)
      {
        Console.WriteLine($"The gas vehicle has {gv.CurrentTankPercentage} of its tank left");
      }

      foreach (IGasVehicle gv in gasVehicles)
      {
        // This should completely refuel the gas tank
        gv.RefuelTank();
      }

      foreach (IGasVehicle gv in gasVehicles)
      {
        Console.WriteLine($"Now the vehicle is full at {gv.CurrentTankPercentage}%");
      }
    }
  }
}
