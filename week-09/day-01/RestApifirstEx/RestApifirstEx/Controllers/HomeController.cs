using System;
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

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] Arrays Item)
        {
            if (Item.numbers==null||Item.what==null)
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
            else
            {
                if (Item.what=="sum")
                {
                    return Json(new { result = Item.numbers.Sum() });
                }
                else if (Item.what== "multiply")
                {
                    int multi = 1;
                    for (int i = 0; i < Item.numbers.Length; i++)
                    {
                        multi = Item.numbers[i] * multi;
                    }
                    return Json(new { result = multi });
                }
                else if (Item.what== "double")
                {
                    for (int i = 0; i < Item.numbers.Length; i++)
                    {
                        Item.numbers[i] = Item.numbers[i] * 2;
                    }
                    return Json(new { result = Item.numbers });
                }
                else
                {
                    return Json(new { result = Item.numbers.Sum() });
                }
            }
        }

    }
}

