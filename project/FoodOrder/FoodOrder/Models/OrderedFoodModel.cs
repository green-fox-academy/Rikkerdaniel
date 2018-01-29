using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class OrderedFoodModel
    {
        public int Id { get; set; }
        public string FoodName { get; set; }
        public string Day { get; set; }
        public string User { get; set; }
    }
}
