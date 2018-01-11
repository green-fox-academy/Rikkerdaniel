using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestionLine.Models;

namespace QuestionLine.Controllers.Home
{
    [Route("")]
    public class HomeController : Controller
    {
        public static List<Person> PersonList = new List<Person>();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Log")]
        public IActionResult Login(string level)
        {
            if (level =="Mentor")
            {
                return RedirectToAction("Mentor");
            }
            return RedirectToAction("Student");
        }

        [HttpGet("Student")]
        public IActionResult Student()
        {
            return View();
        }

        [HttpGet("Mentor")]
        public IActionResult Mentor()
        {
            return View(PersonList);
        }

        [HttpPost("addLine")]
        public IActionResult AddToLine(string name)
        {
            PersonList.Add(new Person{ Name=name});
            return RedirectToAction("Student");
        }

        [HttpPost("removeLine")]
        public IActionResult RemoveLine(string name)
        {
            PersonList.RemoveAll((p)=>p.Name==name);
            return RedirectToAction("Mentor");
        }
    }
}
