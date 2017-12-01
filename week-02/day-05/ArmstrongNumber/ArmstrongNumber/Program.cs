using System;

namespace ArmstrongNumber
{
    class Program
    {
        public static string Isarmstrong = ("");
        static bool Judge()
        {
            Console.WriteLine("Give me that number");
            Isarmstrong = Console.ReadLine();
            char[] digitarray = Isarmstrong.ToCharArray();
            double a = 0;
            for (int i = 0; i < Isarmstrong.Length; i++)
            {
                string s = Convert.ToString(digitarray[i]);
                double b = Convert.ToDouble(s);
                a = a + (Math.Pow(b, Isarmstrong.Length));
            }
            if (a == Convert.ToDouble(Isarmstrong))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Output()
        {
            if (Judge())
            {
                Console.WriteLine("The " + Isarmstrong + " is an armstrong number :)");
            }
            else
            {
                Console.WriteLine("Sorry" + Isarmstrong + " is not an armstrong number");
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Output();


        }
    }
}
