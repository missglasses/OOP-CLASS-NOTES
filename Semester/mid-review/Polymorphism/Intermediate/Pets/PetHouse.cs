using System;
using System.Collections.Generic;

public class PetHouse {
    public void MakeNoise(List<Pet>pets){ //shorter version of the commented code below
        foreach (var pet in pets){
            pet.MakeNoise();
        }
    }
}

/*var myPets = new List<Pet> {
    new Dog(),
    new Cat(),
    new Bird()
};

petHouse.MakeNoise(myPets);
*/