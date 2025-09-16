// See https://aka.ms/new-console-template for more information

using System;

public abstract class Vehicle
{
    // TODO: Declare an abstract method StartEngine()
    public abstract void StartEngine();
}

// Car class
public class Car : Vehicle {
    public override void StartEngine(){
          Console.WriteLine("Car engine started. Vroom vroom!");  
    }
}

// Motorcycle class
public class Motorcycle : Vehicle {
    public override void StartEngine(){
        Console.WriteLine("Motorcycle engine started. Broom broom!");
    }
}

class Program
{
    static void Main()
    {
        // TODO: Create Car and Motorcycle objects and call StartEngine()
        Vehicle car = new Car();
        car.StartEngine();
        Vehicle motor = new Motorcycle();
        motor.StartEngine();
    }
}
