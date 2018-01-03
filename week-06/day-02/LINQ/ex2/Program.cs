using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var averageOfOdds = n.Where(p => (p % 2) == 1||(p%2)== -1).Average(p=>p);
            Console.WriteLine(averageOfOdds);
            Console.ReadKey();
        }
    }
}
