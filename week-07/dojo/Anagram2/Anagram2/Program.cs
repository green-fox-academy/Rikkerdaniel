using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public bool IsAnagram(string stringToCheckIfAnagramOrNot1, string stringToCheckIfAnagramOrNot2)
        {
            int counter = 0;
            try
            {
                for (int i = 0; i < stringToCheckIfAnagramOrNot1.Length; i++)
                {
                    if (stringToCheckIfAnagramOrNot1.Contains(stringToCheckIfAnagramOrNot2[i]))
                    {
                        counter += 0;
                    }
                    else
                    {
                        counter += 1;
                    }
                }
                if (counter == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }
        }

        public bool AMethodThatReturnsTheLengthOfTwoSeparateStringsWithBooleanValues(string stringWhichWeNeedToKnowTheLengthOf1, string stringWhichWeNeedToKnowTheLengthOf2)
        {
            if (stringWhichWeNeedToKnowTheLengthOf1.Length == stringWhichWeNeedToKnowTheLengthOf2.Length)
            {
                return true;
            }
            return false;
        }
    }
}
