using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Services;


namespace FoodOrder.Controllers
{
    [Route("")]
    public class LoginController : Controller
    {
        public LoginController(OrderFoodService orderFoodService)
        {
            OrderFoodService = orderFoodService;
        }

        public OrderFoodService OrderFoodService { get; set; }

        [HttpGet("")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("")]
        public IActionResult LoginCheck(string username, string password)
        {
            if (OrderFoodService.CheckLogin(username,password))
            {
                return Redirect($"home/{username}");
            }
            return RedirectToAction("LoginPage"); 
        }
    }
}
