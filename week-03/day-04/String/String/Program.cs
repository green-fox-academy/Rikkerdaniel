using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string thing = Console.ReadLine();
            Console.WriteLine(Replace(thing));
            Console.ReadKey();
        }
        static string Replace(string text)
        {
            text = text.Replace("x", "y");
            return text;
        }

    }
}
