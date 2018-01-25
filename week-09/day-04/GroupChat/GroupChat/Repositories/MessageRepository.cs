using GroupChat.Entities;
using GroupChat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Repositories
{
    public class MessageRepository
    {

        public MessageRepository(MessageContext messageContext)
        {
            MessageContext = messageContext;
        }

        public MessageContext MessageContext { get; set; }

        internal void SendMessage(string content,string user)
        {
            Message newMessage = new Message()
            {
               Content=content,
               User=user,
               DateOfSend=DateTime.Now
            };
            MessageContext.Add(newMessage);
            MessageContext.SaveChanges();
        }
    }
}
