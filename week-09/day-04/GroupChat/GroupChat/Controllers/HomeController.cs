using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupChat.Services;
using GroupChat.Models;
using Microsoft.Web.WebSockets;
using System.Threading;

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
        public IActionResult UserLog(string user, string password)
        {
            if (user != null && password == "barba")
            {
                MessageService.MessageViewModel.CurrentUser = user;

                return Redirect($"chatroom/{user}");
            }
            return RedirectToAction("LoginPage");
        }

        [HttpGet("chatroom/{user}")]
        public IActionResult ChatRoom([FromRoute] string user)
        {
            //HttpContext.Current.AcceptWebSocketRequest(new ChatWebSocketHandler(user));
            MessageService.MessageViewModel.CurrentUser = user;
            MessageService.MessageViewModel.MessageList = MessageService.ListOfMessages();
            return View(MessageService.MessageViewModel);
        }

        [HttpPost("sendmessage")]
        public IActionResult SendMessage(string Content, string user)
        {
            if (Content == null)
            {
                return RedirectToAction($"chatroom/{user}");
            }
            MessageService.SendMessage(Content, user);
            return Redirect($"chatroom/{user}");
        }
    }

    class ChatWebSocketHandler : WebSocketHandler
    {
        private static WebSocketCollection chatClients = new WebSocketCollection();
        private string username;

        public ChatWebSocketHandler(string user)
        {
            username = user;
        }

        public override void OnOpen()
        {
            chatClients.Add(this);
        }

        public override void OnMessage(string message)
        {
            chatClients.Broadcast(username + ": " + message);
        }
    }
}

