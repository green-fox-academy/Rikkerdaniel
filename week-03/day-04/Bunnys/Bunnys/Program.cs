using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunnys
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnys = int.Parse(Console.ReadLine());
            int ear = 0;
            Console.WriteLine( EarCounter(bunnys, ear));
            Console.ReadLine();
        }
        static int EarCounter(int bunny,int ears)
        {
            if (bunny >0)
            {
                return EarCounter(bunny - 1, ears + 2);
            }
            else
            {
                return ears;
            }
        }
    }
}
