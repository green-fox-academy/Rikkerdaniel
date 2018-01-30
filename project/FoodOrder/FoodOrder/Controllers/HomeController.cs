using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Services;

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
                return View("kitchenLady");
            }
            return View();
        }
    }
}
