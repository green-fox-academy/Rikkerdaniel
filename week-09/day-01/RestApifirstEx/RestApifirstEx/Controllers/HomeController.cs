﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApifirstEx.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApifirstEx.Controllers
{
    [Route("")]

    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable == null)
            {
                return Unauthorized();
            }
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromRoute]string what, [FromBody] Item input)
        {
            int sum = 0;
            int fact = 1;
            if (input.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what == "sum" )
            {
                for (int i = 1; i < input.until + 1; i++)
                {
                    sum += i;
                }
                return Json(new { result = sum });
            }
            else if (what == "factor" )
            {
                for (int i = 1; i < input.until+1; i++)
                {
                    fact = fact * i;
                }
                return Json(new { result = fact });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

    }
}
//        [HttpPost("dountil/{what}")]
//        public IActionResult Dountil([FromRoute] string what, [FromBody] Item input)
//        {
//            if (input.until != null)
//            {
//                switch (what)
//                {

//                    case "sum":
//                        int sum = 0;
//                        for (int i = 1; i < input.until + 1; i++)
//                        {
//                            sum += i;
//                        }
//                        return Json(new { result = sum });

//                    case "factor":
//                        int factorial = 1;
//                        for (int i = 1; i < input.until + 1; i++)
//                        {
//                            factorial *= i;
//                        }
//                        return Json(new { result = factorial });

//                    default:
//                        break;
//                }
//            }
//            return Json(new { error = "Please provide a number!" });
//        }
//    }
//}

