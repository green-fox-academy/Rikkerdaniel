using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBank.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBank.Controllers
{
    [Route("")]
    public class SimbaController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            var simba = new BankAccount() { Name = "Simba", Balance = 2000.01F,Currency="Zebra", AnimalType = "Animal.Lion" };
            return View(simba);
        }
    }
}
