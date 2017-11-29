using System;
using System.Collections.Generic;

namespace IDontKnowWTFImDoing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            var list2 = new List<string>();
            list2.Add(list[2]);
            list[2] = list[5];
            list[5] = list2[0];
            foreach (string item in list)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
