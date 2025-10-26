using System;

public class MaleFriend : Friend,BoyFriend{
    
    private int flowersGiven=0;
    private FemaleFriend lover;
    
    public MaleFriend() : base('M'){}
    
    public override void SetLover(Lover lover){
        this.lover=(FemaleFriend)lover;
    }
    
    public override void GiveLove(){
           Console.WriteLine("mwamwa");
     
            lover.ReceiveLove();
        
    
    }
    
    public void GiveFlowers(int flowerCount){
      flowersGiven+=flowerCount;
      lover.ReceiveFlowers(flowerCount);
        //  Console.WriteLine($"FlowersGiven: {flowersGiven}");
         
        //  if(lover!=null && lover is GirlFriend girlFriend){
        //      girlFriend.ReceiveFlowers(flowerCount);
        //  }
    }
    
    // public int FlowersGiven=>flowersGiven;
    // public FemaleFriend Lover = lover;
  
}
