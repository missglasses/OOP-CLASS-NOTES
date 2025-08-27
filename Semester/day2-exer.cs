// See https://aka.ms/new-console-template for more information


using System; //library

class Program { //classname should also be the filename (before)

    static void Main(){

    Console.WriteLine("=======My Calculator Program =======");
    Console.WriteLine("by Cindy Lepatan");

    int num1, num2, sum, quo, prod, diff, choice;
    // string choice;
    
    Console.WriteLine("Enter the first number:  ");
    num1= Convert.ToInt32(Console.ReadLine()); //typecast

    Console.WriteLine("Enter the second number: ");
    num2= Convert.ToInt32(Console.ReadLine());  //typecast

    Console.WriteLine("Choose an operation from 1-4 || [1] + [2] - [3] * [4] /)");
    // choice  = Console.ReadLine(); //gets operation
    choice = Convert.ToInt32(Console.ReadLine());


    //operations
    switch (choice){

     case 1:
        sum = num1+num2;
       Console.WriteLine("Result {0} + {1} = {2}", num1, num2, sum);
        //    Console.WriteLine("Sum is "+sum);
        break;

    case 2:
         diff = num1-num2;
        //    Console.WriteLine("Difference is "+diff);
        Console.WriteLine("Result {0} - {1} = {2}", num1, num2, diff);
        break;

    case 3:
     prod = num1*num2;
        //    Console.WriteLine("Product is "+prod);
        Console.WriteLine("Result {0} * {1} = {2}", num1, num2, prod);
        break;

    case 4:
     quo = num1-num2;
        //    Console.WriteLine("Quotient is "+quo);
        Console.WriteLine("Result {0} / {1} = {2}", num1, num2, quo);
        break; 
    
    }

   

}

}


