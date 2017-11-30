using System;
using System.Collections.Generic;

namespace LIstSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 34, 12, 24, 9, 5 };
            list.Sort();
            for (int i = 0; i < list.Count ; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
