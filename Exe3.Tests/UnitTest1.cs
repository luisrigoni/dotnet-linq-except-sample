using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exe3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArrayExceptTest()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };
            int[] result = { 1, 29, 42, 98, 234 };

            var diff = primeiroArray.Except(segundoArray);

            Assert.IsTrue(result.SequenceEqual(diff)); // Useless test
        }
    }
}
