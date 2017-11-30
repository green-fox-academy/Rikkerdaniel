using System;

namespace SumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me how many  numbers do you want to sum and average");
            int counter = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < counter ; i++)
            {
                Console.WriteLine("Give me Another number");
                a = a + Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("sum = "+ a +"" + "\n average = "+(a/counter ));
            Console.ReadKey();
            
        }
    }
}
