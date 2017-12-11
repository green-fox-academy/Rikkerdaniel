using System;
using System.Collections.Generic;

namespace Domino
{
    public class Dominoes
    {
        public static int lockout = 0;

        public static void Main(string[] args)
        {
            Linemaker();
            Console.ReadKey();
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
            return dominoes;
        }
        public static void Linemaker()
        {
            var dominoes = InitializeDominoes();

            int[] curentdomino = dominoes[0].GetValues();
            Console.WriteLine(curentdomino[0] + "," + curentdomino[1]);

            while (lockout != dominoes.Count)
            {
                for (int i = 1; i < dominoes.Count; i++)
                {
                    int[] nextdomino = dominoes[i].GetValues();

                    if (curentdomino[1] == nextdomino[0])
                    {
                        Console.WriteLine(nextdomino[0] + "," + nextdomino[1]);
                        curentdomino = nextdomino;
                        lockout++;
                    }
                }
            }
        }

    }
}
