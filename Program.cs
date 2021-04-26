using System;
using System.Collections.Generic;

namespace inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      List<Zero> electricVehicles = new List<Zero>() { fx, fxs };

      Cessna mx410 = new Cessna();

      fxs.Drive();
      modelS.Drive();
      mx410.Drive();
    }
  }
}
