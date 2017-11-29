using System;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            int a  = quote.IndexOf("I");
            a = a+2;
            quote = quote.Insert(a, " always takes longer than");
            Console.WriteLine(quote);
            Console.ReadKey();
        }
    }
}
