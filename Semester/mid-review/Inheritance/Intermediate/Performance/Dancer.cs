using System;

public class Dancer : Performer{
    private string danceStyle;

    //constructor
   public Singer(string name, int age, string danceStyle):base (name,age){
    this.danceStyle=danceStyle;
   }

    //methods
    public string GetDanceStyle{
        return danceStyle;
    }
   

    public void Dance(){
        Console.WriteLine($"{GetName()} is performing {danceStyle} dance.");
    }
}