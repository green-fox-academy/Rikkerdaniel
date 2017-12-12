using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenOO
{
    class Tree:Plant 
    {
        public Tree(int Water, string Color)
        {
            waterStatus = Water ;
            color = Color;
            Name="tree";
        }
    }
   
}
