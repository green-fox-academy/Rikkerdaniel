using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IAmGroot.Controllers
{
    [Route("")]
    public class GuardianController : Controller
    {
        [Route("/")]
        [HttpGet("groot")]
        public IActionResult Index(string message)
        {
            if (message==null)
            {
                return Json(new { error = "I am Groot!" });
            }
            return Json(new { recived= message, translated= "I am Groot!" });
        }

        [HttpGet("yondu")]
        public IActionResult YoundusArrow(int distance ,int time)
        {
            if (time==0)
            {
                return Json(new { error = "You Are Stupid!" });
            }
            return Json(new { Distance = distance, Time = time , Speed=distance/time });
        }
    }
}
