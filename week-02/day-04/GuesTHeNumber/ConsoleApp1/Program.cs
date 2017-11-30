using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int guessthis = r.Next(0, 10);
            Console.WriteLine("I think a number between 0 and 10 , can you guess ?");
            int end = 0;
            while (end == 0)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > guessthis)
                {
                    Console.WriteLine("too big");

                }
                else if (guess < guessthis)
                {
                    Console.WriteLine("Too small");
                }
                else if (guess == guessthis)
                {
                    Console.WriteLine("Congrats you win");
                    end++;
                }
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
