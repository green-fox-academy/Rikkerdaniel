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
            char[] c = { 'a', 'b', 'c', 'd' };
            var evens = n.Where(p => (p % 2) == 0);

            var averageOfOdds = n.Where(p => (p % 2) == 1).Average();

            var squaredOfPositive = n.Where(p => p > 0).Select(p => p * p);

            var squaredIsMoreThan20 = n.Where(p => (p * p) > 20);

            int[] n1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var valuesCounted = (from r in n1
                                 group r by r.CompareTo(r)
                                 into g
                                 select g.Count()).ToArray();
            foreach (var item in valuesCounted)
            {
                Console.WriteLine(item);
            }

            var charToString = c.ToString();

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var StartAEdndI = cities.Where(p => p.StartsWith("A")).Where(p => p.EndsWith("I"));

            string a = "asdADmkuiklhgJUZHkloikuhdBVFG";
            var isUpper = a.Where(p => char.IsUpper(p));

            Console.ReadKey();
        }
    }
}
