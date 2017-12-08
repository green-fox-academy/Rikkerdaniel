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
        static void Decrypter(int key, string path)
        {
            var sr = new StreamReader(path, true);
            string str = "        ";
            string line1 = sr.ReadToEnd();

            char[] chars = line1.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                int UnicodeChar = Convert.ToInt32(chars[i]);
                UnicodeChar = UnicodeChar + key;
                if (UnicodeChar == 31)
                {
                    str += " ";
                }
                else if (UnicodeChar == 12)
                {
                    str += "\n";
                }
                else
                {
                    char decryptedChar = Convert.ToChar(UnicodeChar);
                    str += decryptedChar.ToString();
                }
            }
            sr.Close();
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the path for your file!");
            string path = Console.ReadLine();
            //@"C:\Users\rikda\Desktop\asbest\greenfox\Rikkerdaniel\week-03\day-01\decrypt\decrypt\dec.txt"
            Console.WriteLine("Give me the key ");
            int key = int.Parse(Console.ReadLine());
            Decrypter(key, path);
            Console.ReadKey();
        }
    }
}
