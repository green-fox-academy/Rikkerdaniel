using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using FoodOrder.Models;

namespace FoodOrder.Entities
{
    public class FoodOrderContext : DbContext
    {
        public FoodOrderContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<MenuModel> MenuModels { get; set; }
        public DbSet<OrderedFoodModel> OrderedFoodModels { get; set; }
        public DbSet<UserModel> UserModels { get; set; }
    }
}
