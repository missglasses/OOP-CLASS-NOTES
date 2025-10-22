using System;

public class Performer {
    private string name;
    private int age;

    //constructor
    public Performer(string name, int age){
        this.name=name;
        this.age=age;

    }

    //method
    public string GetName(){
        return name;
    }

    public int GetAge(){
        return age;
    }
}