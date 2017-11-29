using System;

namespace Suming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a NUmber ");
            int number = Convert.ToInt32(Console.ReadLine());
            Sum(number);
            Console.ReadKey();
        }
        static void Sum(int num)
        {
           int a= num * (num + 1) / 2;
            Console.WriteLine(a );
        }
    }
}
