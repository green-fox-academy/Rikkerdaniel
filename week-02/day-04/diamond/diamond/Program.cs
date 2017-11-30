using System;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number");
            int layers = Convert.ToInt32(Console.ReadLine());
            int Space = 0;
            int Number = 0;


            for (int i = 1; i <= layers; i++)
            {
                for (Space = 1; Space <= (layers - i); Space++)
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++)
                    Console.Write("*");
                for (Number = (i - 1); Number >= 1; Number--)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int i = 1; i <= layers; i++)
            {
                for (Number = 1; Number <= i; Number++)
                    Console.Write(" ");
                for (Space = 1; Space <= (layers - i); Space++)
                    Console.Write("*");
                for (Space = 2; Space <= (layers - i); Space++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadKey();
           
        }
    }
}
