using System;

class House
{
    //properties
    public string Roof;
    public bool Electricity;
    public int Doors;
    public int Windows;

    // methods 
    public void OpenDoors()   
    {
        Console.WriteLine("Doors are now open!");
    }
    
    public void OpenWindows()  
    {
        Console.WriteLine("Windows are now open!");
    }
    
    public void TurnElecOn()
    {
        if (Electricity)
            Console.WriteLine("Electricity turned on!");
        else
            Console.WriteLine("No electricity available!");
    }
}

//inheritance
class Mansion : House
{
    public Mansion()
    {
        Roof = "Slate";
        Electricity = true;
        Doors = 10;
        Windows = 20;
    }
}

// /inheritance
class Bungalow : House
{
    public Bungalow()
    {
        Roof = "Shingle";
        Electricity = true;
        Doors = 4;
        Windows = 8;
    }
}

class Program 
{
    static void Main(string[] args)
    {
        // objects 
        Mansion mansion = new Mansion();
        Bungalow bungalow = new Bungalow();  
        
        mansion.OpenDoors();    
        mansion.TurnElecOn();   
        
        bungalow.OpenWindows(); 
    }
}
