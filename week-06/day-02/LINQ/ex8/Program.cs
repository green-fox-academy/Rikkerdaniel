using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "asdADmkuiklhgJUZHkloikuhdBVFG";
            var isUpper = a.Where(p => char.IsUpper(p));
        }
    }
}
