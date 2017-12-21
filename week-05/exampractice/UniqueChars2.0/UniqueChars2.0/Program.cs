using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars2._0
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "apple";
            char[] CharsList = input.ToCharArray();
            var outputList = new List<char>();
            outputList = UniqueCharListMaker(CharsList);
            for (int i = 0; i < outputList.Count; i++)
            {
                Console.WriteLine(outputList[i]);
            }
            Console.ReadKey();
        }
        public static  List<char> UniqueCharListMaker(char[] chars)
        {
            var uniqoeCharsList = new List<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                int characterCounter = 0;
                for (int j = 0; j < chars.Length; j++)
                {
                    if (chars[i] == chars[j])
                    {
                        characterCounter++;
                    }
                }
                if (characterCounter == 1)
                {
                    uniqoeCharsList.Add(chars[i]);
                }
            }

            return uniqoeCharsList;
        }
    }
}
