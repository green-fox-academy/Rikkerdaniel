using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace Anagram
{
    [TestFixture]
    class AnagramTest
    {
        Program asd = new Program();

        [TestCase]
        public void IsNumber()
        {
            Assert.IsTrue(asd.SuchMethodName("helicopter", "helicopter"));
        }
        [TestCase]
        public void IsNumber3()
        {
            Assert.IsTrue(asd.SuchMethodName("helicopter", "helicopter"));
        }
    }
}
