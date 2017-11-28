using System;

namespace ChangeArrayElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = { 1, 2, 3, 8, 5, 6 };
            s[3] = 4;
            Console.WriteLine(s[3]);
            Console.ReadKey();
        }
    }
}
