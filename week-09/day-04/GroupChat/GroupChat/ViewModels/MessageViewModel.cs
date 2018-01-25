using GroupChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.ViewModels
{
    public class MessageViewModel
    {
        public List<Message> MessageList { get; set; } = new List<Message>();
        public  string CurrentUser  { get; set; }
    }
}
