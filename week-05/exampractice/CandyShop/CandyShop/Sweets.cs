using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperCandyShop
{
    public class Sweets
    {
        public double Price { get; set; }
        public double Sugar { get; set; }
        public string Type { get; set; }

        public Sweets(double price, double sugar, string type)
        {
            Price = price;
            Sugar = sugar;
            Type = type;
        }
    }
}