using System;

public class Program
{
    public static void Main(string[] args) 
    {
       Animal pomeranian = new Dog(); //we cannot create an obj using animal without the use of child classes (abstract)
       Animal siamese = new Cat();
       pomeranian.MakeSound();
       pomeranian.sleep();
       siamese.MakeSound();
       siamese.sleep();
       
       
    }
}

abstract class Animal{
    public abstract void MakeSound(); //NOTE: child class are required to implement this
    
    public void sleep(){
          Console.WriteLine ("zzZZzzzzZZZ");
    }
}

class Dog : Animal {
    
    public override void MakeSound(){ 
        //override to avoid redundancy
     Console.WriteLine ("Woof Woof!");
     }
}

class Cat : Animal {
    
    public override void MakeSound(){
        Console.WriteLine ("Purrrrrrrrrrrrr!");
    }
}

/*OUTPUT: 
Woof Woof!
zzZZzzzzZZZ
Purrrrrrrrrrrrr!
zzZZzzzzZZZ

*/
