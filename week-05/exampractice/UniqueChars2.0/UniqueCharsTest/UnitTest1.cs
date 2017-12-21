using System;

using NUnit.Framework;
using UniqueChars2._0;
using System.Collections.Generic;

namespace UniqueCharsTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            string input = "apple";
            char[] CharsList = input.ToCharArray();
            List<char> list = Program.UniqueCharListMaker(CharsList);
            Assert.AreEqual(list[0], 'a');
        }

        [Test]
        public void TestMethod2()
        {
            string input = "apple";
            char[] CharsList = input.ToCharArray();
            List<char> list = Program.UniqueCharListMaker(CharsList);
            Assert.AreEqual(list[1], 'l');
        }
    }
}
