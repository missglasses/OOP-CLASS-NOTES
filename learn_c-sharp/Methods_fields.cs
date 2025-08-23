using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest();
      //fields of type string
      f.name = "Congo";
      f.trees = 0;
      //fields of type int
      f.age = 0;
      f.biome = "Tropical";
      
      Console.WriteLine(f.name);
    }
  }
}
