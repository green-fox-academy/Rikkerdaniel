using System;
using NUnit.Framework;
using AnagramTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrang
            var thing = new Program();
            //act
            bool anag = thing.IsAnagram("asdf","fdsa");
            //Asset
            Assert.True(anag);
        }
    }
}
