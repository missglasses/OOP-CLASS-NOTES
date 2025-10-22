using System;

public class Singer : Performer {
    private string vocalRange;

    public Singer(string name, int age,string vocalRange):base(name,age){
        this.vocalRange=vocalRange;
    }

    public string GetVocalRange{
        return vocalRange;
    }

    public void Sing(){
        Console.WriteLine($"{{GetName()} is singing with a {vocalRange} range.}");
    }
}