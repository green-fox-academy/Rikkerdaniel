using System;
using System.Collections.Generic;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            if (List.Contains(7))
            {
                Console.WriteLine("hoooraaaayyyyy");
            }
            else
            {
                Console.WriteLine("nooooo:(((");
            }
            Console.ReadKey();
        }
    }
}
