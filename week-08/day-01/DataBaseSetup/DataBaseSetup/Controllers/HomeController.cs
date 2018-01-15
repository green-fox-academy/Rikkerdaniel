using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataBaseSetup.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataBaseSetup.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private TestContext testContext;
 
         public HomeController(TestContext testContext)
         {
             this.testContext = testContext;
         }

    [HttpGet("")]
        public IActionResult Index()
        {
            var SomefromDataBase = testContext.Tests.Where(p => p.Id == 1);
            return Json(SomefromDataBase);
        }
    }
}
