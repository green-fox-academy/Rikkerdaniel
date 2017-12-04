using System;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the number of soldiers");
            byte[] binary = BitConverter.GetBytes(Convert.ToInt32(Console.ReadLine()));

            for (int i = 0; i < binary .Length ; i++)
            {
                if (binary [i]==1)
                {
                    binary[i] = 0;
                    binary[binary.Length] = 1;
                    break;
                }

            }


            Console.WriteLine(Convert.ToInt32 (binary));
            Console.ReadLine();
        }
    }
}

