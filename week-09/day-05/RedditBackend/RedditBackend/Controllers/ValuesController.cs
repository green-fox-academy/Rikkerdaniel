using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedditBackend.Services;
using RedditBackend.Models;

namespace RedditBackend.Controllers
{
    [Route("[controller]")]
    public class ValuesController : Controller
    {
        public ValuesController(RedditService redditService)
        {
            RedditService = redditService;
        }

        public RedditService RedditService { get; set; }

        [HttpGet("")]
        public IActionResult Get()
        {
            var allPosts = RedditService.GetAllPosts();
            return Json(new { posts = allPosts });
        }

        [HttpPost("")]
        public IActionResult Create([FromBody] RedditPost post)
        {
            RedditService.CreatePost(post);
            return Json(RedditService.GetLastPost());
        }

    }
}
