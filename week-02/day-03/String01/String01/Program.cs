﻿using System;

namespace String01
{
    class Program
    {
        static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            example.Replace("dishwasher", "galaxy");
            Console.WriteLine(example);
        }
    }
}
