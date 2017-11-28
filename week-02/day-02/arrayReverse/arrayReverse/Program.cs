using System;

namespace arrayReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };
            Array.Reverse(aj);
            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
