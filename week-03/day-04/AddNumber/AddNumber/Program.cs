using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            AddNumber(inputNum, 0);
            Console.ReadLine();
        }
        static int AddNumber(int n, int count)
        {
            if (count <= n)
            {
                Console.WriteLine(count);
                return AddNumber(n, count + 1);
            }
            else
            {

                return count;
            }
        }

    }
}
