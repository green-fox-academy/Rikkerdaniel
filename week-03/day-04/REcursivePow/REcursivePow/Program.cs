using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REcursivePow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            int bas = 4;
            int pow = 3;
            int count = 1;
            Console.WriteLine(   PowStupiditi(bas, pow,count));
            Console.ReadKey();
        }
        static int PowStupiditi(int bas1,int n,int counter)
        {
            if (n  >0)
            {
               return  PowStupiditi(bas1, n-1 ,counter *bas1);
            }
            else
            {
                return counter;
            }
        }
    }
}
