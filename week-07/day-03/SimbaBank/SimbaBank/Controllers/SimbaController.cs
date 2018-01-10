using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimbaBank.Models;
using SimbaBank.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimbaBank.Controllers
{
    [Route("")]
    public class SimbaController : Controller
    {
        public static List<BankAccount> Account  = new List<BankAccount>()
        {
        #region
            new BankAccount()
             {
                Name = "Simba",
                Balance = 2000.01F,
                Currency ="Zebra",
                AnimalType = "Animal.Lion"

             },
             new BankAccount()
             {
                Name = "aslan",
                Balance = 21230.01F,
                Currency ="Zebra",
                AnimalType = "Animal.Lion"

             },
              new BankAccount()
             {
                Name = "Harambe",
                Balance = 4320.01F,
                Currency ="Banana",
                AnimalType = "Animal.Gorilla"

             },
               new BankAccount()
             {
                Name = "Pumba",
                Balance = 10000.01F,
                Currency ="bug",
                AnimalType = "Animal.Pig"

             },
                new BankAccount()
             {
                Name = "Timon",
                Balance = 123400.01F,
                Currency ="bug",
                AnimalType = "Animal.Suricata"

             }

#endregion
        };

        [Route("")]
        public IActionResult Index()
        {
            return View(Account);
        }
    }
}
