//not to hide but for complexity
//Animal a2 = new Animal(); && u cannot do this in abstraction
using System;

class Animal {
     public virtual void Speak()=> Console.WriteLine("The animal makes a sound..");
}

class Dog : Animal {
    public override void Speak()=> Console.WriteLine("The Dog Barks..");
}

class Cat : Animal {
    public override void Speak()=> Console.WriteLine("The Cat meows..");
}

class Program {
    static void Main(){
        
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        
        a1.Speak();
        a2.Speak();
    }
}
