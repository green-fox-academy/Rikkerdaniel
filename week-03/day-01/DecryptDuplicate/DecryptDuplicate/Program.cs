using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {


            string str = "";
            var file = new StreamReader(@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\DecryptDuplicate\DecryptDuplicate\DuplicatedChars.txt");

            String line = file.ReadToEnd();
            char[] chars = line.ToCharArray();
            for (int i = 0; i < chars.Length ;i++)
            {
                if (i%2==1)
                {
                    str += chars[i].ToString();
                }
                

            }
            file.Close();
            Console.WriteLine(str );
            Console.ReadKey();



        }
    }
}
