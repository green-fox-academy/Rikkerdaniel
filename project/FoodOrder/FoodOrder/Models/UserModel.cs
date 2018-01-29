using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public bool IsKonyhasNeni { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
