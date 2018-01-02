using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domino
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();
            foreach (var item in dominoes)
            {
                Console.Write("["+item.GetValues()[0] + " ," + item.GetValues()[1]+"]  ");
            }
            Console.WriteLine("stupidest execise!! why the hell is it good for me to use compare if i can do it better and easier whitout it ? why is this shit good for us ???");
            Console.ReadLine();
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            dominoes.Sort();
            return dominoes;
        }
    }
}
