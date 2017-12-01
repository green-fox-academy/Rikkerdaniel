using System;

namespace Josephus
{
    class Program
    {
        static int Josephus(int n)
        {
            int step = 2;
            if (n <= 2)
            {
                return 1;
            }
            int a= ((n - 1) + (step - 1) % (n + 1));
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Dont want to die in a suicide circel ? Give me the number of people and i save your ass!");


            Console.WriteLine(Josephus(Convert.ToInt32(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
