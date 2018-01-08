using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        static  long Counter = 0;

        public Greeting(long id ,string content)
        {
            Id = id+Counter;
            Counter++;
            Content ="Hello, "+ content;
        }
    }
}
