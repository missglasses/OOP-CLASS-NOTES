using System;


public class Car : VehicleControls{
    
    public void StartEngine(){
        Console.WriteLine("Engine started.");
    }
    public void StopEngine(){
        Console.WriteLine("Engine stopped.");
    }
    public void TurnOnHeadlights(){
        Console.WriteLine("Headlights turned on.");
    }
    public void TurnOffHeadlights(){
        Console.WriteLine("Headlights turned off.");
    }
     public void Honk(){
        Console.WriteLine("Horn sounds.");
    }

}
