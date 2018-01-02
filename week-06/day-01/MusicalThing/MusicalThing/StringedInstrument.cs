using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musical;

namespace MusicalThing
{
    public abstract class StringedInstrument:Instrument
    {
        protected int numberOfStrings;
 
         public StringedInstrument(int numberOfStrings)
         {
             this.numberOfStrings = numberOfStrings;
         }
 
         public StringedInstrument()
         {
 
         }
 
         public override void Play()
         {
             Console.WriteLine(GetType().Name+ " , with "+ numberOfStrings+ " string , and sound like "+ Sound());
         }
 
         public abstract string Sound();
       
    }
}
