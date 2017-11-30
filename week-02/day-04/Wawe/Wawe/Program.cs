using System;
using System.Threading;

namespace Wawe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 100; i++)
            {
                 

                Console.WriteLine("   *   ****");
                Console.WriteLine("  * *  *  *");
                Console.WriteLine("  * *  *  *");
                Console.WriteLine("   *    **");
                Console.WriteLine("   *   ****");
                Console.WriteLine("   ********");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("     HELLO");
                Thread.Sleep(600);
                Console.Clear();
                Console.WriteLine("  *    ****");
                Console.WriteLine(" * *   *  *");
                Console.WriteLine(" * *   *  *");
                Console.WriteLine("  *     **");
                Console.WriteLine("  *    ****");
                Console.WriteLine("   ********");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("       ****");
                Console.WriteLine("     HELLO");
                Thread.Sleep(600);
                Console.Clear();
            }
        }
    }
}
