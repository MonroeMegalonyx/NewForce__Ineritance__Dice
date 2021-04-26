using System;
using System.Collections.Generic;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero()
      {
        MainColor = "Blue",
      };
      Zero fx = new Zero()
      {
        MainColor = "Red",
      };
      Tesla modelS = new Tesla()
      {
        MainColor = "Black",
      };
      Cessna mx410 = new Cessna()
      {
        MainColor = "Yellow",
      };

      //List<Zero> electricVehicles = new List<Zero>() { fx, fxs };

      fxs.Drive();
      fxs.Turn();
      fxs.Stop();
      fx.Drive();
      fx.Turn();
      fx.Stop();
      modelS.Drive();
      modelS.Turn();
      modelS.Stop();
      mx410.Drive();
      mx410.Turn();
      mx410.Stop();
    }
  }
}
