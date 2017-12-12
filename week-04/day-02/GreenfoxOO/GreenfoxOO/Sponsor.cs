using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenfoxOO
{
    class Sponsor:Person
    {
        public Sponsor(string name,int age , string gender,string Company)
        {
            Name = name;
            Age = age;
            Gender = gender;
            company = Company;
        }
        public Sponsor()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "Female";
            company = "Google";
            hiredStudents = 0;
        }

        public string company { get; set; }
        public int hiredStudents { get; set; }

        public override void GetGoal()
        {
            Console.WriteLine( "My goal is : Hire brilliant junior software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm "+Name+", a "+Age+" year old "+Gender+" who represents "+company+" and hired "+ hiredStudents +"students so far.");
        }
        public int Hire()
        {
           hiredStudents = hiredStudents + 1;
            return hiredStudents;
        }
    }
}
