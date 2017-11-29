using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You can use +,-,*,/,%, examle : + 32 27");
            Console.WriteLine("Give me what you what to calculate ");
            char a = Convert.ToChar (Console.Read ());
            Console.ReadKey( );
            int b = Convert.ToInt32(Console.Read());
            Console.ReadKey( );
            int c = Convert.ToInt32(Console.Read());
            Console.ReadKey();
            Console.WriteLine(b + a+c );


            //string v = Console.ReadLine();
            //a.Split( );
            //int b = Convert.ToInt32(a);
            //Console.WriteLine(b );
            //Console.WriteLine(Convert.ToInt32 ((a[1])) + (a[0])+Convert.ToInt32 (( a[2])));
            Console.ReadKey();

            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
        }
    }
}
