using FoodOrder.Entities;
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

    }
}
