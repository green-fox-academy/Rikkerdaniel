using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTest
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public bool IsAnagram(string s1,string s2)
        {
            string s3 = string.Copy(s2);

            for (int i = 0; i < s1.Length; i++)
            {
                if (!s1[i].Equals(' '))
                {
                    if (s3.Contains(s1[i]))
                    {
                        s3 = s3.Remove(s3.IndexOf(s1[i]), 1);
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (s3.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}







