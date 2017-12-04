using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var  sr = new StreamReader(@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\ReverseLines\rev.txt");
            string str = "";
            string line1 = "";
            while ((line1 = sr .ReadLine()) != null)
            {
                char[] chars = line1.ToCharArray();
                
                for (int i = chars.Length; i > 0; i--)
                {
                    str += chars[i - 1].ToString();
                }
                str += "\n";
            }
            sr.Close();
            Console.WriteLine(str  );
            Console.ReadKey();
        }
    }
}
