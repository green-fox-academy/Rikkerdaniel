using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenOO
{
    class Flower:Plant 
    {
        public Flower(int Water,string Color)
        {
            waterStatus = Water ;
            color = Color;
            Name = "flower";

        }
    }
}
