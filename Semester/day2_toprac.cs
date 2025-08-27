// See https://aka.ms/new-console-template for more information


using System; //library

class Program { //classname should also be the filename (before)

    static void Main(){

    Console.WriteLine("=======My Calculator Program =======");
    Console.WriteLine("by Cindy Lepatan");

    float num1, num2, sum, prod, diff, choice;
    float quo;
    // string choice;
    
    Console.WriteLine("Enter the first number:  ");
    // num1= Convert.ToInt32(Console.ReadLine()); //typecast
     num1= Convert.ToSingle(Console.ReadLine()); 

    Console.WriteLine("Enter the second number: ");
    // num2= Convert.ToInt32(Console.ReadLine());  //typecast
    num2= Convert.ToSingle(Console.ReadLine()); 

    Console.WriteLine("Choose an operation from 1-4 || [1] + [2] - [3] * [4] /)");
    // choice  = Console.ReadLine(); //gets operation
    choice = Convert.ToInt32(Console.ReadLine());

//PRAC USING CHARACTER AS INPUT


     /*case '+':
        sum = num1+num;
           Console.WriteLine("Sum is "+sum);
        break;

    case '-':
         diff = num1-num;
           Console.WriteLine("Difference is "+diff);
        break;

    case '*':
     prod = num1*num;
           Console.WriteLine("Product is "+prod);
        break;

    case '/':
     quo = num1-num;
           Console.WriteLine("Quotient is "+quo);
        break;  */

   

}

}

