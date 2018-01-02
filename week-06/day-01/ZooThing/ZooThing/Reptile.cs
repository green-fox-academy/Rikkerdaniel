using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooThing
{
   
    
        class Reptile : Animal
     {
         public Reptile(string name) : base(name)
         {
 
         }
         public override void Greet()
         {
             Console.WriteLine("hello reptile");
         }
 
         public override void WantChild()
         {
            Console.WriteLine( "want a child from an egg");
        }
     }
}

