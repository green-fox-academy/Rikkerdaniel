using System;
using System.Collections.Generic;

namespace Candyshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);
            
            list.RemoveAt(1);
             list.Insert(1, "Croissant");
            list.Remove(false);
            list.Add("Ice cream");
            Console.WriteLine(list);
            Console.ReadKey();
        }
    }
}
