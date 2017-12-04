using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleLines
{
    class Program
    {
        static void Linemaker(string a, string b, int c)
        {
            try
            {
                StreamWriter file2 = new StreamWriter(a);
                for (int i = 0; i < c; i++)
                {
                    file2.WriteLine(b, true);
                }

                file2.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect path or something else went wrong");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the path");
            string path = Console.ReadLine();
            Console.WriteLine("give me the word");
            string word = Console.ReadLine();
            Console.WriteLine("give me the number");
            int num = int.Parse(Console.ReadLine());
            Linemaker(path, word, num);
           
        }
    }
}
