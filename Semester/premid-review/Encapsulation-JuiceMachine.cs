// See https://aka.ms/new-console-template for more information
using System;

class JuiceMachine
{
    // TODO: private fields for flavor and sugarLevel
    private int sugarLevel;
    private string flavor;

    // TODO: Method to set juice
    public void SetJuice(string flavor, int sugarLevel){
        this.flavor=flavor;
        this.sugarLevel=sugarLevel;
    }

    // TODO: Method to serve juice
    public void ServeJuice(){
        Console.WriteLine($"Serving {flavor} juice with {sugarLevel}% sugar");
    }
}

class Program
{
    static void Main()
    {
        // TODO: Test the JuiceMachine
        JuiceMachine jm = new JuiceMachine();
        jm.SetJuice("Mango", 50);
        jm.ServeJuice();
        jm.SetJuice("Apple", 25);
        jm.ServeJuice();
    }
}
