using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Services;
using FoodOrder.Models;

namespace FoodOrder.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(OrderFoodService orderFoodService)
        {
            OrderFoodService = orderFoodService;
        }

        public OrderFoodService OrderFoodService { get; set; }

        [HttpGet("home/{username}")]
        public IActionResult Home([FromRoute] string username)
        {
            if (OrderFoodService.CheckIfKitchenLady(username))
            {
                return Redirect($"kitchen/{username}");
            }
            return View(OrderFoodService.OrderFoodRepository.ListOfMenu());
        }

        [HttpPost("addorder/{username}")]
        public IActionResult AddOrder(string  FoodName, string day, [FromRoute] string username)
        {
            OrderFoodService.AddOrder(FoodName, day, username);
            return Redirect($"thankyou/{username}");
        }

        [HttpGet("thankyou/{username}")]
        public IActionResult ThankYouUser([FromRoute] string username)
        {
            return View(username);
        }
    }
}
