using System;
using System.Collections.Generic;

namespace AppendLeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rok", "halacsk" };

            for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
                Console.WriteLine(far[i]);
            }
            Console.ReadKey();
        }
    }
}
