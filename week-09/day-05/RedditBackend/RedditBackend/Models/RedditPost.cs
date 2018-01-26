﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackend.Models
{
    public class RedditPost
    {
        public long? Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string TimeStamp { get; set; } = DateTime.Now.ToString("dd/MMM/yy");
        public int? Score { get; set; }
    }

}
