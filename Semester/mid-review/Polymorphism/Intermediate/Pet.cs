using System;
using System.Collections.Generic;

public abstract class Pet{
    private string type;
    private bool isFriendly;


    //contsructor 
    protect Pet(string type, bool isFriendly){
        this.type=type;
        this.isFriendly=isFriendly;
    }

    //method
    public abstract void MakeNoise();



}