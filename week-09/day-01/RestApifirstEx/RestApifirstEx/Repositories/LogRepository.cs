using RestApifirstEx.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApifirstEx.Repositories
{
    public class LogRepository
    {
        public LogRepository(LogContext logContext)
        {
            LogContext = logContext;
        }

        public LogContext LogContext { get; set; }

    }
}
