using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFile
{
    class Program
    {
        static void Copy(string inp, string outp)
        {
            int a = 0;
            try
            {
                File.Copy(inp, outp);
            }
            catch (Exception)
            {
                Console.WriteLine("false");
                a++;
            }
            if (a == 0)
            {
                Console.WriteLine("true");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the path of the file what you want to copy");
            string path = Console.ReadLine();
            Console.WriteLine("path of where you want to copy it");
            string a = Console.ReadLine();
            Copy(path, a);
            Console.ReadKey();
        }
    }
}
