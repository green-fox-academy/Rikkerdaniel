using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ashgasvflksjvd aejosdbv svlciaeuovfdjbcn ";

            var frequencyOfChars = from x in a
                                  group x by x into y
                                  select y;

            foreach (var charNo in frequencyOfChars)
            {
                Console.WriteLine("Letter " + charNo.Key + " appears " + charNo.Count() + " times");
            }
            Console.ReadKey();
        }
    }
}
