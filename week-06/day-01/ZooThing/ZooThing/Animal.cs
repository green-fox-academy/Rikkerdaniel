using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooThing
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string color;
        protected int NumberOfLegs;
        public abstract void Greet();
        public abstract void WantChild();
    }
}
