using GroupChat.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Services
{
    public class MessageService
    {
        public  MessageService(MessageRepository messageRepository)
        {
            MessageRepository = messageRepository;
        }

        public MessageRepository MessageRepository { get; set; }

    }
}
