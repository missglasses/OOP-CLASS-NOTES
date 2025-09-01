using System;

nameSpace InheritancePrac { //this is like a folder
    
    class Pet { //base class 
    public string Kind;
    public string Name;
    
     public void display() {
      Console.WriteLine("I am a pet");
    }
}

class Dog:Pet { 
    public void display() {
    Console.WriteLine("My name is "+Name);
    Console.WriteLine("I am a "+Kind);
    }
}

class Cat:Pet {
    public void display(){
        Console.WriteLine("My name is "+Name);
    Console.WriteLine("I am a "+Kind);
    }
}


class Program {
    
    static void Main(){
        Dog pomeranian = new Dog();
        
        pomeranian.Kind="Pomeranian";
        pomeranian.Name="Bonbon";
        pomeranian.display();
        
        Console.WriteLine();
        
        Cat siamese = new Cat();
        siamese.Kind="Siamese";
        siamese.Name="Ana";
        pomeranian.display();
        
    }
}

}
