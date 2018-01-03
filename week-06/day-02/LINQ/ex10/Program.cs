using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxes = new List<Fox>();
            foxes.Add(new Fox("asd", "static", "red"));
            foxes.Add(new Fox("Béla", "corsac", "green"));
            foxes.Add(new Fox("ffghj", "please", "yellow"));
            foxes.Add(new Fox("babinéni", "pallida", "green"));
            foxes.Add(new Fox("cshőő", "corsac", "blue"));
            var greens = foxes.Where(p => p.Color == "green").Select(p=>p);
            var greenCorsac = foxes.Where(p => p.Color == "green").Where(p => p.Type == "corsac").Select(p=>p);
            Console.ReadKey();
        }
    }
}
