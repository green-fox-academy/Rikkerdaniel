using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your hight in meters");
            Double hight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thank you:) \n Now give me your weight in kg please");
            Double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your BMI is :  " + weight /(hight *hight ));
            Console.ReadKey();
        }
    }
}
