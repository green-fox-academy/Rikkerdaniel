using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditProject.Repositories;

namespace RedditProject.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {

        public HomeController(RedditRepository redditRepository)
        {
            RedditRepository = redditRepository;
        }

        public RedditRepository RedditRepository { get; set; }

        [Route("posts")]
        public IActionResult Index()
        {
            return View(RedditRepository.PostList());
        }

        [HttpGet("add")]
        public IActionResult Add()
        {

            return View();
        }

        [HttpPost("addnew")]
        public IActionResult AddNew(string content)
        {
           
           RedditRepository.AddPost(content);
            return RedirectToAction("Index");
        }
    }
}
