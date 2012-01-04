using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class FindMostCommonWord
    {
        [Test]
        public void MostCommonWord()
        {
            var s = "Ala ma kota a kot ma Ala ma";

            var result = s.Split(' ').GroupBy(s1 => s1).OrderBy(g => g.Count()).AsParallel().Last().Key;
            Assert.AreEqual("ma",result);
        }

        [Test]
        public void MostCommonWord2()
        {
            var s = "Ala ma kota a kot ma Ala ma";

            var result = s.Split(' ').GroupBy(s1 => s1).OrderByDescending(g => g.Count()).First().Key;
            Assert.AreEqual("ma",result);
        }
    }
}
