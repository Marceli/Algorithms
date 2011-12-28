using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class StringTest
    {
        [Test]
        public void ReverseTest()
        {
            var s = "abc";
            Assert.AreEqual("cba",s.Reverse());
        }
    }
}
