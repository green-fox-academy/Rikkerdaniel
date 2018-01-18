using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class Reddit
    {
        public long Id { get; set; }
        public int Score { get; set; } = 0;
        public string Content { get; set; }
    }
}
