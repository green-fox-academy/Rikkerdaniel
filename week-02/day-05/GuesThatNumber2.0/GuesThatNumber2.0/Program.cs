using System;
using System.Threading;

namespace GuesThatNumber2._0
{
    class Program
    {
        public static int lives = 0;
        static void Guesser()
        {
            Random r = new Random();
            int guessthis = r.Next(0, 1);

            while (lives < 5)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > guessthis)
                {
                    Console.WriteLine("too big");
                    lives++;
                    Console.WriteLine("You have " + (5 - lives) + " lives left");

                }
                else if (guess < guessthis)
                {
                    Console.WriteLine("Too small");
                    lives++;
                    Console.WriteLine("You have " + (5 - lives) + " lives left");
                }
                else if (guess == guessthis)
                {
                    Console.WriteLine("Congrats you win");
                    break;
                }
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("I think a number between 0 and 100 ,You have 5 livess. Can you guess ?");
            Guesser();

            if (lives == 5)
            {
                Console.WriteLine("You lost :/");
            }

            Console.ReadKey();


        }
    }
}
