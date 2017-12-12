using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenOO
{
    class Program
    {
        public static int needwater = 0;
        public static double water = 40;
        public static List<Plant> things = new List<Plant>();

        static void Main(string[] args)
        {
            List<Plant> things1 = new List<Plant>();


            Flower blueFlower = new Flower(0, "blueflower");
            things1.Add(blueFlower);
            Flower yellowFlower = new Flower(0, "yellowflower");
            things1.Add(yellowFlower);
            Tree redTree = new Tree(0, "redtree");
            things1.Add(redTree);
            Tree greenTree = new Tree(0, "greentree");
            things1.Add(greenTree);
            things = things1;

            GardesStatus();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Watering "+water );
            GardenWatering();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Watering " + water);
            GardenWatering();
            Console.ReadKey();
        }
        public static void GardesStatus()
        {
            for (int j = 0; j < things.Count; j++)
            {
                if (things[j].waterStatus >= 5)
                {
                    Console.WriteLine(things[j].color  + " does not need water!");
                }
                else
                {
                    Console.WriteLine(things[j].color  + " does need water!");
                    needwater++;
                }

            }
        }
        public static void GardenWatering()
        {
            for (int k = 0; k < things.Count; k++)
            {
                if (things[k].waterStatus < 5 && things[k].Name == "flower")
                {
                    things[k].waterStatus = things[k].waterStatus + ((water / needwater) * 0.75);
                }

            }
            for (int i = 0; i < things.Count; i++)
            {
                if (things[i].waterStatus < 10 && things[i].Name == "tree")
                {
                    things[i].waterStatus = things[i].waterStatus + ((water / needwater) * 0.4);
                }

            }
            GardesStatus();
            water = 70;
            needwater = 0;

        }
    }
}

