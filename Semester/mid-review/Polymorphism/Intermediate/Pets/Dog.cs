using System;
using System.Collections.Generic;


public class Dog : Pet {
    public class Dog : base("dog",true);


    public override void MakeNoise(){
        Console.WriteLine("Arf!");
    }
}