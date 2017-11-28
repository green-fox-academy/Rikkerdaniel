using System;

namespace ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = new int[] { 1, 2, 3 };
            int sum = 0;
            for (int i = 0; i < ai.Length; i++)
            {
                sum += ai[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
