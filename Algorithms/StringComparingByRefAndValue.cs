using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class StringComparingByRefAndValue
	{
		[Test]
		public void CompareByValue()
		{
			var olo = "olo";
			var olo1 = "ol";
			var bolo = 'o';

			olo1 += bolo;
			Assert.IsTrue(olo1 == olo);
			Assert.IsFalse(object.ReferenceEquals(olo, olo1));
			Assert.IsFalse(object.Equals(olo, olo1));
		}
	}
}
