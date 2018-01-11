using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreetSomeone.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone.Controllers
{
   

    [Route("")]
    public class HomeController : Controller
    {
        public Name name;
        public HomeController(Name name)
        {
            this.name = name;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(name);
        }
        [HttpPost("add")]
        public IActionResult PostName(Name name)
        {
            this.name.UserName = name.UserName;
            return RedirectToAction("GetName");
        }

        [HttpGet("greet")]
        public IActionResult GetName()
        {
            return View(name);
        }
    }
}
