using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GetIndex
{
    [TestFixture]
    class GetIndexTest
    {
        Program prog = new Program();
       
        [TestCase]
        public void ReturnMinus1()
        {
            Assert.AreEqual(-1, prog.GiveIndex(2316));
        }

        [TestCase]
        public void ReturnTheIndexOfAnEvilNumber()
        {
            Assert.AreEqual(2, prog.GiveIndex(666));
        }

        [TestCase]
        public void ReturnTheIndexOfAnotherNumber()
        {
            Assert.AreEqual(1, prog.GiveIndex(22));
        }

        [TestCase]
        public void ReturnTheIndexOfATotallyDifferentNumber()
        {
            Assert.AreEqual(0, prog.GiveIndex(1));
        }
    }
}
