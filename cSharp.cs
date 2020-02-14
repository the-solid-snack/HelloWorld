using System.Reflection.Emit;
using System.Data;
using Internal;
using System;

namespace Calculator 
{
    class MainClass 
    {
        public static void Main (string[] args) 
        {
         
            int operand1=0; int operand2=0; int result=0;
            
            Console.WriteLine("This is a simple Calculator in C#!\r");
            Console.WriteLine("- - - - - - - - - - - - - - - - - \n");
            
            Console.WriteLine("Type your first operand");
            operand1=ToInt32(Console.ReadLine());
            
            Console.WriteLine("Type your second operand");
            operand2=ToInt32(Console.ReadLine());
        
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch(Console.ReadLine())
            {
            case "a":
                result = operand1 + operand2;
                Console.WriteLine($"{operand1} + {operand2} = {result}");
                break;

            case "s":
                result = operand1 - operand2;
                Console.WriteLine($"{operand1} - {operand2} = {result}");
                break;

            case "m":
                result = operand1 * operand2;
                Console.WriteLine($"{operand1} x {operand2} = {result}");
                break;

            case "d":
                result = operand1 / operand2;
                Console.WriteLine($"{operand1} / {operand2} = {result}");
                break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
            
        }
    }
}