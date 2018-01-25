using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupChat.Services;

namespace GroupChat.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public HomeController(MessageService messageService)
        {
            MessageService = messageService;
        }

        public MessageService MessageService { get; set; }

        public static string loggedUser { get; set; }

        [HttpGet("")]
        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpPost("userlog")]
        public IActionResult UserLog(string user)
        {
            if (user == null)
            {
                return RedirectToAction("LoginPage");
            }
            loggedUser = user;
            return Redirect("chatroom");
        }

        [HttpGet("chatroom")]
        public IActionResult ChatRoom()
        {
            return View(MessageService.ListOfMessages());
        }

        [HttpPost("sendmessage")]
        public IActionResult SendMessage(string Content)
        {
            if (Content==null)
            {
                return RedirectToAction("ChatRoom");
            }
            MessageService.SendMessage(Content,loggedUser);
            return RedirectToAction("ChatRoom");
        }
    }
}
