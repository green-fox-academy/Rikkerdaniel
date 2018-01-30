using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class MenuModel
    {
        public long Id { get; set; }
        public string Day { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
