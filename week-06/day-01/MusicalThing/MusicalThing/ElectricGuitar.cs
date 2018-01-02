using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musical;

namespace MusicalThing
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int numberOfStrings) : base(numberOfStrings)
        {

        }

        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }
        public override string Sound()
        {
            return "Twang";
        }
    }
}
