using System;

namespace AnimalLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many chickens do you have ?");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now tell me how many pigs do you have ");
            int pigs= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your animals has : " + ((chickens *2)+(pigs *4)));
            Console.ReadKey();
        }
    }
}
