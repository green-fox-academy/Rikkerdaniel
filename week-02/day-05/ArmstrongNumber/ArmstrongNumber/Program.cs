using System;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me that number");
            string  isarmstrong = Console.ReadLine();
            char[] digitarray= isarmstrong.ToCharArray();
            double  a = 0;
            for (int i = 0; i < isarmstrong.Length ; i++)
            {
                string s = Convert.ToString(digitarray[i]);
                double b = Convert.ToDouble(s );
                a = a +( Math.Pow(b, isarmstrong.Length));
            }
            if (a==Convert.ToDouble (isarmstrong ))
            {
                Console.WriteLine("The "+ isarmstrong + " is an armstrong number :)");
            }
            else
            {
                Console.WriteLine("Sorry"+isarmstrong +" is not an armstrong number");
            }
            Console.ReadKey();

        }
    }
}
