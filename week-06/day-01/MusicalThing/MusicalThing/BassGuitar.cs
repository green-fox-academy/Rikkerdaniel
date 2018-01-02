using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musical;

namespace MusicalThing
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar(int numberOfStrings) : base(numberOfStrings)
        {

        }

        public BassGuitar()
        {
            numberOfStrings = 4;
        }
        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
