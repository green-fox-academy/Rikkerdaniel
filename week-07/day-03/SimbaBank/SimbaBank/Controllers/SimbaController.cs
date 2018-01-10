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
        public static List<BankAccount> Account = new List<BankAccount>()
        {
        #region
            new BankAccount()
             {
                Name = "Simba",
                Balance = 2000,
                Currency ="Zebra",
                AnimalType = "Animal.Lion",
                IsKing = true

             },
             new BankAccount()
             {
                Name = "aslan",
                Balance = 21230,
                Currency ="Zebra",
                AnimalType = "Animal.Lion",
                IsKing = false

             },
              new BankAccount()
             {
                Name = "Harambe",
                Balance = 4320.01,
                Currency ="Banana",
                AnimalType = "Animal.Gorilla",
                IsKing = false

             },
               new BankAccount()
             {
                Name = "Pumba",
                Balance = 10000.01,
                Currency ="bug",
                AnimalType = "Animal.Pig",
                IsKing = false

             },
                new BankAccount()
             {
                Name = "Timon",
                Balance = 123400.01,
                Currency ="bug",
                AnimalType = "Animal.Suricata",
                IsKing = false

             }

#endregion
        };

        [Route("")]
        public IActionResult Index()
        {
            return View(Account);
        }

        [HttpPost("add")]
        public IActionResult AddBalance()
        {
            foreach (var BankAccount in Account)
            {
                if (BankAccount.IsKing)
                {
                    BankAccount.Balance += 100;
                }
                else
                {
                    BankAccount.Balance += 10;
                }
            }
                return RedirectToAction("Index");
        }
    }
}
