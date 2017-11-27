using System;

namespace Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            Console.WriteLine("Give me side a of the cuboid");
            double sidea = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me side b of the cuboid");
            double sideb = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me side c of the cuboid");
            double sidec = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Volume: " + sidea *sideb *sidec +"cubed");
            Console.WriteLine("surface: " + (2*(sidea *sideb )+2*(sideb *sidec )+2*(sidec *sidea )) +"squared");
            Console.ReadKey();
        }
    }
}
