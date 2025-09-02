using System;

namespace myProgram{

    class Code {
    
    
   static void Main(){
      int setAttempts=3;
      string myPass="secret";
      string input ="";
      
     int i;
     for (i=setAttempts; i>0; i--){
           Console.Write("Enter the password: ");
           input = Console.ReadLine();
           
           if(input==myPass){
                 Console.WriteLine("Access granted!");
                 break;
           } else {
                Console.WriteLine($"Access denied! {i-1} attempts remaining.");
           }
           if(i-1==0) {
                Console.WriteLine("Access denied!");
           }//oh no finish na
     }
     
    
   
    }
    }
}
