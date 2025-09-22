using System;

public class Person
{
    private string name;
    private int age;
    private char gender;
    
    public string GetName(){
        // Console.WriteLine($"Name: {name}");
         return name;
    } 

    public void SetName(string name){

     this.name=name;
 
    } 

    public int GetAge(){
        // Console.WriteLine($"Age: {age}");
        return age;
    }

    public void SetAge(int age){
        this.age=age;
    }

    public char GetGender(){
    //  Console.WriteLine($"Gender: {gender}");
     return gender;
    }   
    
    public void SetGender(char gender){
    //m or f
        if(gender == 'M' || gender=='F'){
            this.gender=gender;
        } else {
            Console.WriteLine("Invalid\n");
        }
    }
}




// public class Program{
    
//     public static void Main(){
//         Person p1 =new Person();
//     //set ni
//     p1.SetName("John Doe");
//     p1.SetAge(30);
//     p1.SetGender('M');
    
//     //get ni
//     p1.GetName();
//     p1.GetAge();
//     p1.GetGender();
//     }
    
// }
