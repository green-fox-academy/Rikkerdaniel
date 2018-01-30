using FoodOrder.Entities;
using FoodOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Repositories
{
    public class OrderFoodRepository
    {
        public OrderFoodRepository(FoodOrderContext foodOrderContext)
        {
            FoodOrderContext = foodOrderContext;
        }

        public FoodOrderContext FoodOrderContext { get; set; }

        internal void AddOrder(string foodName, string day, string username)
        {
            OrderedFoodModel newOrder= new OrderedFoodModel()
            {
               FoodName=foodName,
               Day=day,
               User=username,
            };
            FoodOrderContext.Add(newOrder);
            FoodOrderContext.SaveChanges();
        }
    }
}
