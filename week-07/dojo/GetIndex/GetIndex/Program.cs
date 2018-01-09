using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetIndex
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int GiveIndex(int number)
        {
            List<int> SuperList = new List<int> { 1, 22, 666 };

            try
            {
                var index = SuperList.IndexOf(number);
                return index;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
