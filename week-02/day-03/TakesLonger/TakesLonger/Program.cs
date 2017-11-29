using System;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("bot", "odd");

            int last = url.IndexOf("/");

            url = url.Insert(5, ":");
            Console.WriteLine(url);
            Console.ReadKey();
            //string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            //int  = url.IndexOf("/");

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

            //Console.WriteLine(quote);
        }
    }
}
