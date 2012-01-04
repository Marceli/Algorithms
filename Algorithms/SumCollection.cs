using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class SumCollection
    {
        [Test]
        public void Test()
        {
            Enumerable.Range(1, 9).Sum();
            Assert.AreEqual(5,Enumerable.Range(1, 5).Max());
        }
    }
}
