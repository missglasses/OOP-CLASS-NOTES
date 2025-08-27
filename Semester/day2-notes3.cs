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
    person1.Name="Gran";
    person1.Age=50;

    person1.Introduce();

    Person person2 = new Person(); //second instantiation; person2 is an instance
    person2.Name="Patwek";
    person2.Age=45;

      person2.Introduce();

    }


}
