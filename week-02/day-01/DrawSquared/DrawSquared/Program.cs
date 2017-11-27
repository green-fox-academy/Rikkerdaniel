using System;

namespace DrawSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int number= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("%%%%%");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("%   %");
            }
            Console.WriteLine("%%%%%");
            Console.ReadKey();
        }
    }
}
