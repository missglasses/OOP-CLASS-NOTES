// See https://aka.ms/new-console-template for more information
using System;

//$ dotnet run console -n Inheritance

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name}, and I am {Age} years old.");
    }
}

// TODO: Create Student class here (inherits Person)
class Student : Person {
     public string Grade {get; set;}
    public void Study(){
        Console.WriteLine($"I am studying in grade {Grade}.");
    }
}

// TODO: Create Teacher class here (inherits Person)
class Teacher : Person {

    public string Subject {get; set;}
    public void Teach(){
        Console.WriteLine($"I am teaching {Subject}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: Create a Student object, set values, and call methods
        Student s = new Student();
        s.Name = "Clairo";
        s.Age=15;
        s.Grade="9th";
        s.Introduce();
        s.Study();


        // TODO: Create a Teacher object, set values, and call methods
        Teacher t = new Teacher();
        t.Name = "There";
        t.Age=17;
        t.Subject="Math";
        t.Introduce();
        t.Teach();
    }
}
