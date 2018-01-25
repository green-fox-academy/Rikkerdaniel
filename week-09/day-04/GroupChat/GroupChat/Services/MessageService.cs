using GroupChat.Models;
using GroupChat.Repositories;
using GroupChat.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Services
{
    public class MessageService
    {
        public  MessageService(MessageRepository messageRepository,MessageViewModel messageViewModel)
        {
            MessageRepository = messageRepository;
            MessageViewModel = messageViewModel;
        }

        public MessageRepository MessageRepository { get; set; }
        public MessageViewModel MessageViewModel { get; set; }
      

        public List<Message> ListOfMessages()
        {
            List<Message> ListOfMessages = new List<Message>();

            foreach (var item in MessageRepository.MessageContext.Messages)
            {
                ListOfMessages.Add(item);
            }

            return ListOfMessages;
        }

        internal void SendMessage(string Content, string user)
        {
            MessageRepository.SendMessage(Content,user);
        }
    }
}
