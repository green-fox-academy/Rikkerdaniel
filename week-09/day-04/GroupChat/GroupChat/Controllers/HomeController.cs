using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GroupChat.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("userlog")]
        public IActionResult UserLog(string username)
        {
            if (username == null)
            {
                return RedirectToAction("LoginPage");
            }
            return RedirectToAction("ChatRoom");
        }

    }
}
