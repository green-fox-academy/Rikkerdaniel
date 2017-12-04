using System;
using System.IO;

namespace PrintLines
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string[] content = File.ReadAllLines(@".\my-file.txt");

                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(content[i]);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Uh -oh, could not read the file!");
            }

            Console.ReadLine();

        }
    }
}
