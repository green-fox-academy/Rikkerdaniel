using Microsoft.EntityFrameworkCore;
using RestApifirstEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApifirstEx.Entities
{
    public class LogContext :DbContext
    {
        public LogContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Log> Logs { get; set; }
    }
}
