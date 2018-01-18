using Microsoft.EntityFrameworkCore;
using RedditProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Entities
{
    public class RedditContext : DbContext
    {
        public RedditContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Reddit> Reddits { get; set; }
    }
}
