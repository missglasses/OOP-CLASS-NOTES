
using System;

public class Car {
    private string color;
    private double price;
    private char size;
    
    
    public Car(string color, double price, char size){
        this.color=color;
        this.price=price;
        this.size=Char.ToUpper(size);
    } //use charactrer.toupppercase size
    

    
    public string GetColor(){
        return color;
    }
    
    public double GetPrice(){
        return price;
    }
    
    public char GetSize(){
        return size;
    }
    
    public void SetColor(string color){
        this.color=color;
    }
    
    public void SetPrice(double price){
        this.price=price;
    }
    
    public void SetSize(char size){
        this.size=Char.ToUpper(size);
    }
    
    public override string ToString(){
        
        string sizes;
        
        switch(size){
            case 'S':
            sizes="small";
            break;
            
            case 'M':
            sizes="medium";
            break;
            
            case 'L':
            sizes="large";
            break;
            
            default : 
            sizes = size.ToString();
            break;
        }
        
        return $"Car ({color}) - P{price:F2} - {sizes}"; //f2 is like .2f
    }
}
