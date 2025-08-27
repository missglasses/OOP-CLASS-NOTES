// See https://aka.ms/new-console-template for more information


using System; //library

class Person {

    public string Name;
    public int Age;

    public void Introduce(){
        Console.WriteLine($"Hi, My name is {Name} and I am {Age} years old."); //$ is also for concatinating
    }

}

class Program {

    static void Main(){

    Person person1= new Person(); //object is person1 and Person as class ||instantiation
    // person1.Name="Gran";
    // person1.Age=50;
    

    //make it dynamic
    Console.WriteLine("Wusyaname: ");
    person1.Name= Console.ReadLine();

     Console.WriteLine("Age: ");
    person1.Age = Convert.ToInt32(Console.ReadLine()); 
   


    person1.Introduce();

    }


}
