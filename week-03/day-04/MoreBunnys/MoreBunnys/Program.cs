using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreBunnys
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunnys = int.Parse(Console.ReadLine());
            int ears = 0;
            Console.WriteLine(WierdBunnys(bunnys, ears));
            Console.ReadKey();
        }
        static int WierdBunnys(int bunny, int ear)
        {
            if (bunny % 2 == 0 && bunny != 0)
            {
                return WierdBunnys(bunny - 1, ear + 3);
            }
            else if (bunny % 2 == 1)
            {
                return WierdBunnys(bunny - 1, ear + 2);
            }
            else
            {
                return ear;
            }
        }
    }
}
