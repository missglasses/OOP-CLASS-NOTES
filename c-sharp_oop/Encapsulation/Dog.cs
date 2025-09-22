// Start typing your code
using System;

public class Dog{
    private string breed;
    private int barkCount;
    
    public string GetBreed(){
        return breed;
    }
    
    public void SetBreed(string breed){
        this.breed=breed;
    }
    
    public int GetBarkCount(){
        return barkCount;
    }
    
    public bool HasBarkedALot(){
        return barkCount>=100;
    }
    
    public void Bark(int n){
       for (int i=0; i<n; i++){
           Console.WriteLine("Woof");
       }
       barkCount+=n;
    }
}
