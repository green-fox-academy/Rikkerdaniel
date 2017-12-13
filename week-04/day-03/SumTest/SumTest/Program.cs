using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTest
{
    public class Program
    {
        static void Main(string[] args)
        {
           

        }
        public int Summer()
        {
            var intlist = new List<int>();
            intlist.Add(0);
            intlist.Add(1);
            intlist.Add(2);

            int sum = 0;
            for (int i = 0; i < intlist.Count; i++)
            {
                sum += intlist[i];
            }
                return sum;
        }
    }
}
