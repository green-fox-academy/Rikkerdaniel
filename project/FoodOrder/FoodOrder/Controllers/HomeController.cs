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
                return View("kitchenLady");
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
            return Ok();
        }

        [HttpGet("menu/{username}")]
        public IActionResult GetMenu([FromRoute] string username)
        {
            return View(OrderFoodService.OrderFoodRepository.ListOfMenu());
        }

        [HttpGet("editmenu/{username}")]
        public IActionResult EditMenu([FromRoute] string username)
        {
            return View(OrderFoodService.OrderFoodRepository.ListOfMenu());
        }

        [HttpPost("newmenu/{username}")]
        public IActionResult NewMenu(List<MenuModel>newMenuList, [FromRoute] string username)
        {
            OrderFoodService.EditMenu(newMenuList);
            return Redirect($"home/{username}");
        }

        [HttpGet("orders/{username}")]
        public IActionResult ListAllOrders([FromRoute] string username)
        {
            return View(OrderFoodService.OrderFoodRepository.ListOfMenu());
        }

    }
}
