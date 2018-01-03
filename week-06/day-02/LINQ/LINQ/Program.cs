using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evens = n.Where(p => (p % 2) == 0);
            var averageOfOdds = n.Where(p => (p % 2) == 1).Average();
            var squaredOfPositive = n.Where(p => p > 0).Select(p => p * p);
            var squaredIsMoreThan20 = n.Where(p => (p * p) > 20);
        }
    }
}
