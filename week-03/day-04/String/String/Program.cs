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
            if (text.Length == 0)
            {
                return "";
            }
            if (text[0] == 'x')
            {
                text = "y" + text.Substring(1);
            }
            
              return text[0] + Replace(text.Substring(1));
        }
       
    }
}
