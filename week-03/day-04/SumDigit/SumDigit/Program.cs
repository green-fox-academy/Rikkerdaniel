using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse (Console.ReadLine());  
            Console.WriteLine(SumDigit(number));
            Console.ReadLine();
        }
        private static int SumDigit(int number)
        {
            if (number / 10 > 0)
            {
                Console.WriteLine(number);
                return number % 10 + SumDigit(number / 10);
            }
            else
            {
                return number % 10;
            }
        }
    }
}

