using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            var sr = new StreamReader(@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\decrypt\decrypt\dec.txt",true );
            string str = "";
            string line1 = sr .ReadToEnd(); 

            char[] chars = line1.ToCharArray();

            for (int i = 0; i <chars.Length ; i++)
            {
                int b = Convert.ToInt32(chars[i]);
                b =b-1;
                if (b == 31)
                {
                    str += " ";
                }
                else if (b==12)
                {
                    str += "\n";
                }
                else  
                {
                    char c = Convert.ToChar(b);


                    str += c.ToString();
                }

            }
            

            sr.Close();


           
            Console.WriteLine(str );
            Console.ReadKey();
        }
    }
}
