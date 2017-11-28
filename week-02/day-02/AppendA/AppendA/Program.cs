using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            Console.WriteLine(AppendA(am));
            Console.ReadKey();
        }
        static string AppendA(string text)
        {
            return text + "a";
        }
    }
}
