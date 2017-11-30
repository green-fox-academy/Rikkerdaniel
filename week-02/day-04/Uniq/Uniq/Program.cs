using System;
using System.Collections.Generic;

namespace Uniq
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 11, 34, 11, 52, 61, 1, 34 };
            var list2 = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (!list2.Contains(list[i]))
                {
                    list2.Add(list[i]);
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]+"  ");
            }
            Console.ReadKey();

        }
    }
}
