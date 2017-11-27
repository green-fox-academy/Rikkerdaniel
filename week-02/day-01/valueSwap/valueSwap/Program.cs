using System;

namespace valueSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int c = 0;
            c = b;
            b = a;
            a = c;
            Console.WriteLine(a +" "+ b);
            Console.ReadKey();
        }
    }
}
