using System;

namespace Fibonacci
{
    class Program
    {

        static int fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wich fibonacci number do you want ??");


            Console.WriteLine(fib(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
