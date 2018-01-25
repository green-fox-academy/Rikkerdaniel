using GroupChat.Entities;
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
    }
}
