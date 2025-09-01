using System;

namespace InheritancePrac //assume this is a folder
{
    class Pet //base class
    {
        public string Kind;
        public string Name;

        public virtual void Display()
        {
            Console.WriteLine("I am a pet");
        }

        public void Eat()
        {
            Console.WriteLine("Nomnom!!!");
        }
    }

    class Dog : Pet //subclass
    {

        public override void Display()
        {
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("I am a " + Kind);
        }

        public void Bark()
        {
            Console.WriteLine($"Arf arf! {Name} is barking");
        }
    }

    class Cat : Pet //subclass
    {
        public override void Display()
        {
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("I am a " + Kind);
        }

        public void Meow()
        {
            Console.WriteLine($"Meowww! Purrrr {Name} meows");
        }
    }

    class Program 
    {
        static void Main()
        {
            Dog pomeranian = new Dog();

            pomeranian.Kind = "Pomeranian";
            pomeranian.Name = "Bonbon";
            pomeranian.Display();
            pomeranian.Bark();

            Console.WriteLine();

            Cat siamese = new Cat();
            siamese.Kind = "Siamese";
            siamese.Name = "Ana";
            siamese.Display();
            siamese.Meow();
        }
    }
}
