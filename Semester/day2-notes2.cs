// See https://aka.ms/new-console-template for more information


using System; //library

class Program { //classname should also be the filename (before)

    static void Main(){
    //   Console.WriteLine("Hello from the Main method!");
    //   string name = Console.ReadLine();
    //   Console.WriteLine("Hello user!, " +name);

    int num1, num2, sum;
    
    Console.WriteLine("Enter num1: ");
    num1= Convert.ToInt32(Console.ReadLine()); //typecast

    Console.WriteLine("Enter num2: ");
    num2= Convert.ToInt32(Console.ReadLine());  //typecast

    
    sum =num1+num2;

    Console.WriteLine("Sum is "+sum);

    }

}




