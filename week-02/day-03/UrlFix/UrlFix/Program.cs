﻿using System;

namespace UrlFix
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https//www.reddit.com/r/nevertellmethebots";
            url = url.Replace("bot", "odd");
            url = url.Insert(5, ":");
            Console.WriteLine(url);
            Console.ReadKey();
        }
    }
}
