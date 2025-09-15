using System;

class Person {
    private string name;
    private int age;

    //getter and setters
    //property
    public string Name {
        get { return name; }
        set { name = value; }
    }

    public int Age {
        get { return age; }
        set {
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("age cannot be a negative val");
        }
    }
}

class Program {
    static void Main() {
        Person p = new Person();
        p.Name = "Jem";
        p.Age = -5;
        Console.WriteLine($"{p.Name}, {p.Age}");
    }
}
