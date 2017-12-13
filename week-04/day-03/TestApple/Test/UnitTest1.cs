using System;
using NUnit.Framework;
using TestApple;


namespace Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //arrange
            var program = new Program();

            //act
            string a = program.Asd();


            //assert
            Assert.AreEqual("apple", a);
        }
    }
}
