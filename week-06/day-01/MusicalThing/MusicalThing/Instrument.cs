using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Musical;

namespace MusicalThing
{
    public abstract class Instrument
    {
        protected string name;
        public abstract void Play();
    }
}
