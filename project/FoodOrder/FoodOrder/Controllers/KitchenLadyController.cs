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
    public class KitchenLadyController : Controller
    {
        public KitchenLadyController(OrderFoodService orderFoodService)
        {
            OrderFoodService = orderFoodService;
        }

        public OrderFoodService OrderFoodService { get; set; }

        [HttpGet("kitchen/{username}")]
        public IActionResult KitchenView([FromRoute] string username)
        {
            return View();
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
        public IActionResult NewMenu(List<MenuModel> newMenuList, [FromRoute] string username)
        {
            OrderFoodService.EditMenu(newMenuList);
            return Redirect($"kitchen/{username}");
        }

        [HttpGet("orders/{username}")]
        public IActionResult ListAllOrders([FromRoute] string username)
        {
            return View(OrderFoodService.OrderFoodRepository.ListOfMenu());
        }
    }
}
