using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me that numer :D");
            int num = Convert.ToInt32(Console.ReadLine());
            factorio(num);
            Console.ReadKey();
            // - Create a function called `factorio`
            //   that returns it's input's factorial
        }
        static void factorio(int number)
        {
            int a = number ;
            for (int i = 1; i < number ; i++)
            {
                a = a * i;
            }
            Console.WriteLine("factorial of your number is : "+a );
        }
    }
}
