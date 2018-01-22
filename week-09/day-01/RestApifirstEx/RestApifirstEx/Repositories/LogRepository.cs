using RestApifirstEx.Entities;
using RestApifirstEx.Models;
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

        public void AddToDatabase(string endPoint,string Data)
        {
            Log newLog = new Log()
            {
                endpoint= endPoint,
                data=Data,
                createdAt=DateTime.Now
            };
            LogContext.Add(newLog);
            LogContext.SaveChanges();
        }
    }
}
