using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            Console.WriteLine(RThing(reversed));
            Console.ReadKey();
        }
        static string RThing(string a)
        {
            string b = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                b = b + (Convert.ToString(a[i]));

            }
            return b;

        }
    }
}
