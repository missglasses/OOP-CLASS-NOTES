using System;
using System.Collections.Generic;

public class Cat : Pet {
    public Cat() : base ("cat", true) {}

    public override void MakeNoise(){
        Console.WriteLine("Meow!");
    }
}