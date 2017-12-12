using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOO
{
    class Mentor:Person 
    {
        public Mentor(string name, int age, string gender,string  level)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Level = level;
        }
        public Mentor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
            Level = "intermediate";
        }
        
        public string Level { get; set; }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is : Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm "+Name+", a "+Age+" year old"+ Gender+" "+ Level+" mentor.");
        }
    }
}
