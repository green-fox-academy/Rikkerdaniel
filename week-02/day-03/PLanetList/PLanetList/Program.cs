using System;
using System.Collections.Generic;

namespace PLanetList
{
    class Program
    {
        static void Main(string[] args)
        {

            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList.Insert(5, "Saturn,");
            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.ReadKey();
        }
    }
}
