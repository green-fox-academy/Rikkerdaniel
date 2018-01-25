using GroupChat.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupChat.Entities
{ 
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Message> Messages { get; set; }
    }
}
