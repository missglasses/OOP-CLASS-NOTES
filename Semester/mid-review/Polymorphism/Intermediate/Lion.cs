using System;
using System.Collections.Generic;

public class Lion : Pet {

    public Lion : base("lion", false);

    public override void MakeNoise(){
        Console.WriteLine("Roar!");
    }

}
}