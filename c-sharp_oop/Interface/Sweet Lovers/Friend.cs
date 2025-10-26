using System;

public abstract class Friend: Lover {
    private char gender;
    private bool isLoved=false;
    // protected Lover lover;
    
    public Friend(char gender){
        this.gender=gender;
        // this.isLoved=false;
    }
    
 
    public void ReceiveLove(){
         isLoved=true;
    }
    
     public override string ToString(){
        // Console.WriteLine($"{gender} - {isLoved}");
       return $"{gender} - {isLoved}";
    }
    
    public abstract void SetLover(Lover lover);
    public abstract void GiveLove();
    
    
    // public char Gender(){
    //     return gender;
        
    // }
    
    // public bool IsLoved(){
    //      return isLoved;
    // }
    
    // // public Lover Lover (){
    // //      return lover;
    // // }
    
    // public char Gender =>gender;
    // public bool IsLoved =>isLoved;
    // public Lover Lover => lover;
  
    // public Lover Lover =>  return myLover;

   
}
