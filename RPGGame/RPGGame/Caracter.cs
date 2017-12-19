using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public class Caracter
    {
        public int HP { get; set; }
        public int ATK { get; set; }
        public int DEF { get; set; }
        //0, 1, 0, 1, 0, 1, 0, 0, 0, 1,
        //0, 1, 0, 0, 0, 1, 0, 1, 0, 0,
        //0, 1, 1, 1, 0, 1, 0, 1, 1, 0,
        //0, 0, 0, 0, 0, 1, 0, 0, 0, 0,
        //1, 1, 0, 1, 1, 0, 0, 0, 1, 0,
        //0, 0, 0, 1, 0, 0, 0, 0, 1, 0,
        //0, 1, 0, 1, 0, 1, 1, 0, 1, 0,
        //0, 1, 0, 0, 0, 1, 1, 0, 1, 1,
        //0, 1, 1, 1, 0, 0, 0, 0, 0, 0,
        //0, 0, 0, 0, 0, 1, 1, 0, 1, 0,
        //0, 1, 0, 1, 0, 1, 0, 0, 0, 0
}
}
