using System;

namespace myProgram{
    class Program{
        static void Main(){
            Console.Write("Enter an integer: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
        
            Console.WriteLine("\nMultiplication Table");
            int row, col;
          for(row=1; row<=size; row++){
              for (col=1; col<=size; col++){
                 Console.Write(row*col+"\t"); 
                 
              }
              Console.WriteLine();
          }
    }
}
}
