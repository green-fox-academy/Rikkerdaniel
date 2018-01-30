using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
                return Ok();
            }
            return RedirectToAction("LoginPage"); 
        }
    }
}
