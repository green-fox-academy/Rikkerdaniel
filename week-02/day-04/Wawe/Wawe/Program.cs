using System;
using System.Threading;

namespace Wawe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 2;
            
            for (int i = 0; i < a; i++)
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
                a++;
            }
        }
    }
}
