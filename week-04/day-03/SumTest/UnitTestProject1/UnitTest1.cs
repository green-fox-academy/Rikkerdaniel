using System;
using NUnit.Framework;
using SumTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            var program = new Program();
            //act
           int result = program.Summer();
            //assert
            Assert.AreEqual(3,result);
        }
    }
}
