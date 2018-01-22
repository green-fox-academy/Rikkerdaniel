using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestApifirstEx.Models;
using RestApifirstEx.Services;

namespace RestApifirstEx.Controllers
{
    [Route("")]

    public class HomeController : Controller
    {
        public HomeController(LogService logService)
        {
            LogService = logService;
        }

        public LogService LogService { get; set; }

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
            return Json(new { received = input, result = LogService.Doubling(input) });
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
            return Json(new { welcome_message = LogService.Greeter(name, title) });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable == null)
            {
                return Unauthorized();
            }
            return Json(new { appended = LogService.AppendA(appendable)});
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromRoute]string what, [FromBody] Item input)
        {
            if (input.until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }
            if (what == "sum")
            {
                return Json(new { result = LogService.DoUntilSum(input) });
            }
            else if (what == "factor")
            {
                return Json(new { result = LogService.DoUntilFactor(input) });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] Arrays Item)
        {
            if (Item.numbers == null || Item.what == null)
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
            else
            {
                if (Item.what == "sum")
                {
                    return Json(new { result = Item.numbers.Sum() });
                }
                else if (Item.what == "multiply")
                {
                    return Json(new { result = LogService.ArrayMultiply(Item.numbers) });
                }
                else if (Item.what == "double")
                {
                    return Json(new { result = LogService.ArrayDouble(Item.numbers) });
                }
                else
                {
                    return Json(new { result = Item.numbers.Sum() });
                }
            }
        }

    }
}

