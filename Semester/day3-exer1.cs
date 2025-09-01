using System;

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
    
    public int Grade { get; set; }
    
    public void Study(){
         Console.WriteLine($"I am studying in grade {Grade}.");
    }
}

// TODO: Create Teacher class here (inherits Person)
class Teacher : Person {
    
    public string Subject { get; set; }
    
    public void Teach(){
         Console.WriteLine($"I am teaching {Subject}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // TODO: Create a Student object, set values, and call methods
        Student s1 = new Student();
        s1.Name= "Chiz Beloy";
        s1.Age=73;
        s1.Grade=10;
        s1.Introduce();
        s1.Study();
        
        Console.WriteLine();
        // TODO: Create a Teacher object, set values, and call methods
        Teacher t1 = new Teacher();
        t1.Name= "Granito";
        t1.Age = 88;
        t1.Subject="OOP";
        t1.Introduce();
        t1.Teach();
    }
}
