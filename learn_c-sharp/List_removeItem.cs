using System;
using System.Collections.Generic;

namespace LearnLists
{
  class Program
  {
    static void Main()
    {
      List<double> marathons = new List<double>
      {
        144.07,
        143.12,
        146.73,
        146.33
      };
      

      //prints second element
      Console.WriteLine(marathons[1]);
      
      //removes item
      bool removed = marathons.Remove(143.12);
      
      Console.WriteLine(marathons[1]);
    //check if removed
      Console.WriteLine(removed);

    }
  }
}
