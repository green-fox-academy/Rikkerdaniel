using System;
using System.Text;

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            var fleet = new Fleet();
            var thing = new Thing("Get milk");
            var thing1 = new Thing("Remove the obstacles");
            var thing2 = new Thing("Stand up");
            var thing3 = new Thing("Eat lunch");
            fleet.Add(thing);
            fleet.Add(thing1);
            fleet.Add(thing2);
            fleet.Add(thing3);
            thing2.Complete();
            thing3.Complete();
            fleet.Print();
            Console.ReadLine();
        }
    }
}