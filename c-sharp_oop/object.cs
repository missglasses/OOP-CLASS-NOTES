using System;

namespace MyApplication
{
  class Car
  {
    string color = "white";
    string model = "ferrari";

    static void Main(string[] args)
    {
      Car car1 = new Car();
      Console.WriteLine(car1.color);
      Console.WriteLine(car1.model); //prints white ferrari
    }
  }
}
