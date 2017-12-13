using System;
using NUnit.Framework;
using FibonacciTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Arrange
            var prog = new Program();
            //Act
            int output = prog.Fib(5);
            //Assert
            Assert.AreEqual(5,output);
        }
    }
}
