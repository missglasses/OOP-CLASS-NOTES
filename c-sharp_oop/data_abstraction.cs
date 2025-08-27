
using System;

//data abstraction hides certain details and showing only essential info to the user

using System;

// Data abstraction hides certain details and shows only essential info to the user
abstract class Animal 
{
    public abstract void animalSound();
    public void sleep() 
    {
        Console.WriteLine("Zzz");
    }
}

//ex 1: hidden details
class Pig : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The pig says: Oink Oink!");
    }
}

//ex 2:
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: Woof Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // using abstraction - we only see the essential methods
        Animal myPig = new Pig();
        Animal myDog = new Dog();
        
        Console.WriteLine("Animal Sounds:");
        Console.WriteLine("--------------");
        
        myPig.animalSound();
        myPig.sleep();       //uses inheritance
        
        Console.WriteLine();
        
        myDog.animalSound(); 
        myDog.sleep();      
        
        // ex 3: error: 
        // Animal genericAnimal = new Animal();
       //note: cannot create instance of abstract class
    }
}
