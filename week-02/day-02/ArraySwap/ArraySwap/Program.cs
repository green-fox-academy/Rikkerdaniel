using System;

namespace ArraySwap
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = { "first", "second", "third" };
            string swapper = abc[0];
            abc[0] = abc[2];
            abc[2] = swapper;
            Console.WriteLine(abc[0] + abc[2]);
            Console.ReadKey();
        }
    }
}
