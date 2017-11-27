using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give me the second number");
            int number2= Convert.ToInt32(Console.ReadLine());
            if (number1 >number2 )
            {
                Console.WriteLine(" "+number1 +"  is bigger");
            }
            else if (number2 >number1 )
            {
                Console.WriteLine(" "+number2 +"  is bigger");
            }
            else
            {
                Console.WriteLine("You gave me the same numbers you idiot ! i said an other one");
            }
            Console.ReadKey();
        }
    }
}
