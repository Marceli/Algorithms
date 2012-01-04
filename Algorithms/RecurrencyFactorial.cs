using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class RecurrencyFactorial
    {
        [Test]
        public void FactorialTest()
        {
            Assert.AreEqual(6,Factorial(3));
            Assert.AreEqual(24,Factorial(4));
        }

        private int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
                return n*Factorial(n - 1);
        }
    }
}
