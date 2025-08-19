using System;

namespace DefineParameters
{
  class Program
  {
    static void Main(string[] args)
    {
      VisitPlanets(3);
    }
    
    static void VisitPlanets(int numberOfPlanets) //<--method with param
    {
      Console.WriteLine($"You visited {numberOfPlanets} new planets..."); 
    }
  }
}
