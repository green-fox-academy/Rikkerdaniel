using FoodOrder.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Services
{
    public class OrderFoodService
    {
        public OrderFoodService(OrderFoodRepository orderFoodRepository)
        {
            OrderFoodRepository = orderFoodRepository;
        }

        public OrderFoodRepository OrderFoodRepository { get; set; }

        public bool CheckLogin(string username, string password)
        {
            var checkUser = OrderFoodRepository.FoodOrderContext.UserModels.Where(p => p.Username == username && p.Password == password);
            if (checkUser.Count()>0)
            {
            return true;
            }
            return false;
        }

        public bool CheckIfKitchenLady(string username)
        {
            var checkIfKitchenLady = OrderFoodRepository.FoodOrderContext.UserModels.Where(p => p.Username == username && p.IsKitchenLady);
            if (checkIfKitchenLady.Count()>0)
            {
                return true;
            }
            return false;
        }

        public void AddOrder(string foodName, string day, string username)
        {
            OrderFoodRepository.AddOrder(foodName, day, username);
        }

        public void EditMenu()
        {
            OrderFoodRepository.EditMenu();
        }

    }
}
