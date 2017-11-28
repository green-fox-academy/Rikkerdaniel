using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = Doubling(123);
            Console.WriteLine(ak);
            Console.ReadKey();
        }
        static int Doubling(int ak)
        {
            return ak + ak;
        }
    }
}
