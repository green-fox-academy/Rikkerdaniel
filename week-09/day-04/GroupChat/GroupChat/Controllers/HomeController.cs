using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupChat.Services;
using GroupChat.Models;

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
            MessageService.MessageViewModel.CurrentUser = user;

            return Redirect($"chatroom/{user}");
        }

        [HttpGet("chatroom/{user}")]
        public IActionResult ChatRoom([FromRoute] string user)
        {
            MessageService.MessageViewModel.CurrentUser = user;
            MessageService.MessageViewModel.MessageList = MessageService.ListOfMessages();
            return View(MessageService.MessageViewModel);
        }

        [HttpPost("sendmessage")]
        public IActionResult SendMessage(string Content ,  string user)
        {
            if (Content == null)
            {
                return RedirectToAction($"chatroom/{user}");
            }
            MessageService.SendMessage(Content, user);
            return Redirect($"chatroom/{user}");
        }
    }
}
