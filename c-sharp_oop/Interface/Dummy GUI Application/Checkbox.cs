using System;

public class Checkbox: Clickable {
    private bool isChecked = false;
    private string text;
    
    public Checkbox(string text){
        this.text=text;
    }
    
    public void Click(){
        isChecked=!isChecked;
        if(isChecked){
            Console.WriteLine("Checkbox is checked");
        } else {
             Console.WriteLine("Checkbox is unchecked");
        }
    }
    
    public override string ToString(){
        return $"Checkbox ({text} - Checked = {isChecked})";
    }
}
