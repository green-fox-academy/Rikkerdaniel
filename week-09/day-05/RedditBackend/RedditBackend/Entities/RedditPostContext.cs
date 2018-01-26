using Microsoft.EntityFrameworkCore;
using RedditBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Entities
{
    public class RedditPostContext :DbContext
    {
        public RedditPostContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<RedditPost> RedditPosts { get; set; }
    }
}
