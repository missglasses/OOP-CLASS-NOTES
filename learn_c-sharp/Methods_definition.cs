using System;

namespace DefineAMethod
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(); //func call
    }
    
    static void VisitPlanets() //<---method
    {
      Console.WriteLine("You visited many new planets...");
    }
  }
}
