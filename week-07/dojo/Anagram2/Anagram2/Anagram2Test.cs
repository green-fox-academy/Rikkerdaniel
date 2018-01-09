using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Anagram2
{
    [TestFixture]
    class Anagram2Test
    {
        Program program = new Program();

        [TestCase]
        public void IsAnagram()
        {
            Assert.IsTrue(program.IsAnagram("helicopter", "helicopter"));
        }

        [TestCase]
        public void NotAnagram()
        {
            Assert.IsFalse(program.IsAnagram("helicopter", "alma"));
        }

        [TestCase]
        public void AlsoNotAnagram()
        {
            Assert.IsFalse(program.IsAnagram("helicopter", "körte"));
        }

        [TestCase]
        public void ChecksIfTwoStringsLengthsAreDifferentOrNot1()
        {
            Assert.IsTrue(program.AMethodThatReturnsTheLengthOfTwoSeparateStringsWithBooleanValues("helicopter", "helicopter"));
        }

        [TestCase]
        public void ChecksIfTwoStringsLengthsAreDifferentOrNot2()
        {
            Assert.IsFalse(program.AMethodThatReturnsTheLengthOfTwoSeparateStringsWithBooleanValues("helicopter", "krankenhaus"));
        }
    }
}
