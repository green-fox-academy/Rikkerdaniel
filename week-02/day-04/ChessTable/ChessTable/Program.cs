using System;

namespace ChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("%  ");
                }
                Console.WriteLine("\n");
                if (i%2==0)
                {
                    Console.Write(" ");
                }
                
            }
            Console.ReadKey();
        }
    }
}
