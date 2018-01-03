using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = { 'a', 'b', 'c', 'd' };
            var charToString = new String(c);
            var charToString1 = string.Join(string.Empty,c);
            Console.WriteLine(charToString);
            Console.ReadKey();
        }
    }
}
