using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            CountDown(a);
            Console.ReadKey();
        }
        static int CountDown(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                return CountDown(n - 1);
            }
            else
            {
                return n;
            }

        }
    }
}
