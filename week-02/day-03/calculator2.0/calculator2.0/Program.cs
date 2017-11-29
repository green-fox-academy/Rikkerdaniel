using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator2._0
{
    class Program
    {
        static double operation(int a, int b, char x)
        {
            switch (x)//switch for suvii :) i hope you like it :D
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a * 1.0 / b;


                default:
                    return Math.PI;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Give me that operator!");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Give me the seccond number!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            double check = operation(num1, num2, op);
            if (check == Math.PI)
            {
                Console.WriteLine("you gived me wrong numbers / not numbers or bad operator what i cant use");

            }
            Console.WriteLine(" = " + operation(num1, num2, op));
            Console.ReadKey();
        }

    }
}
