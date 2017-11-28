using System;

namespace PrintArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar = { "first","second"};
            Printer(ar );
            Console.ReadKey();
        }
        static void Printer(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
