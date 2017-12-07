using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci1
{
    class Program
    {
        static int Fib(int n)
        {
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Wich fibonacci number do you want ??");


            Console.WriteLine(Fib(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
