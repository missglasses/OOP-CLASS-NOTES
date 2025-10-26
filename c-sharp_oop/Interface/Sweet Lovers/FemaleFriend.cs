using System;

public class FemaleFriend : Friend,GirlFriend{
    
    private int flowersReceived=0;
    private MaleFriend lover;
    
    public FemaleFriend() : base('F'){}
    
  public override void SetLover(Lover lover){
        this.lover=(MaleFriend)lover;
    }
    
    public override void GiveLove(){
         Console.WriteLine("tsuptsup");
        if(lover!=null){
      
            lover.ReceiveLove();
    }
    }
    
    public void ReceiveFlowers(int flowerCount){
        flowersReceived+=flowerCount;
        // lover.ReceiveLove();
        //  Console.WriteLine($"FlowersReceived: {flowersReceived}");
    }
    
  
//   public int FlowersReceived=>flowersReceived;
    // public MaleFriend Lover = lover;
  
}
