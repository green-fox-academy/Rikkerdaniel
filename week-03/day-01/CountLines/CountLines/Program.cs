using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give me the filename");
            string st = Console.ReadLine();
            try
            {
                string[] b = File.ReadAllLines(st );
                int a = b.Length;
                Console.WriteLine(a );
            }
            catch (Exception)
            {

                Console.WriteLine("0");
            }
            Console.ReadKey();
           
            
        }
    }
}
