using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public Animal()
        {
            hunger = 50;
            thirst = 50;
        }
        public int hunger { get; set; }
        public int thirst { get; set; }

        public void Eat()
        {
            hunger--;
        }

        public void Drink()
        {
            thirst--;
        }

        public void Play()
        {
            hunger++;
            thirst++;
        }
    }
}
