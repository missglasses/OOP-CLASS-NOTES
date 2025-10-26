using System;

public class NormalButton: AbstractButton {
   
    public NormalButton(string title, int width, int height): base(title, width, height){
       
    }
    
    public override void Click(){
        isClicked=!isClicked;
        if(isClicked){
            Console.WriteLine("Button is clicked");
        } else {
             Console.WriteLine("Button is not clicked anymore");
        }
    }
    
    public override void Resize(int newWidth, int newHeight){
        width = newWidth;
        height=newHeight;
    }
    
    public override void Resize(int multiplier){
        width *= multiplier;
        height *=multiplier;
    }
    
    public override string ToString(){
        return $"NormalButton (({width}px, {height}px) - Clicked = {isClicked})";
    }
}
