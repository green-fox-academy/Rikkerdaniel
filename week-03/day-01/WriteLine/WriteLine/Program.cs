using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter file2 = new StreamWriter(@"c:\my-file.txt");
                file2.WriteLine("dani vagyook hello");
                file2.Close();
            }
            catch(Exception )
            {
                Console.WriteLine("This is a shit file not found");
            }
            Console.ReadKey();
        }
    }
}
