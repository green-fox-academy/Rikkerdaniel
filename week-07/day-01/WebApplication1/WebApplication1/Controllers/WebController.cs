using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting()
        {
            var greeting = new Greeting(1,"World")
            {
            };

            return View(greeting);
        }
    }
}
