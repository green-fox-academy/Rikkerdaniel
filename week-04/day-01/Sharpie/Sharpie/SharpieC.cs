using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharpie
{
    class SharpieC
    {
        public SharpieC(string color, float width)
        {
            color = color;
            width = width;
            inkAmount = 100;
        }

        public string color { get; set; }
        public float width { get; set; }
        public float inkAmount { get; set; }

        public void Use()
        {
            inkAmount--;
        }
    }
}
