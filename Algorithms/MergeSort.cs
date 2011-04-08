using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class MergeSort
	{
		[Test]
		public void CanSort()
		{
			var result = Sort(new []{1, 5, 4, 3, 2});
			Assert.AreEqual(new[] {1, 2, 3, 4, 5},result);
			result = Sort(new[] { 5, 4, 3, 2, 1 });
			Assert.AreEqual(new[] { 1, 2, 3, 4, 5 }, result);
			result = Sort(new[] { 5, 4, 3, 3, 1 });
			Assert.AreEqual(new[] { 1, 3, 3, 4, 5 }, result);

		}

		private int[] Sort(int[] ints)
		{
			if(ints.Count()==1)
				return ints;
			int center = ints.Count()/2;
			return Merge(Sort(ints.Take(center).ToArray()), Sort(ints.Skip(center).ToArray()));
		}

		[Test]
		public void CanMerge()
		{
			var result = Merge(new[] { 1, 4 }, new[] { 2, 3 });
			Assert.AreEqual(new[] {1, 2, 3, 4},result);
			Assert.AreEqual(new[] { 1, 2, 3 }, Merge(new[] { 1 }, new[] { 2, 3 }));
		}

		private int[] Merge(int[] ints, int[] ints1)
		{
			var result = new int[ints.Count() + ints1.Count()];
			var i = 0;
			var j = 0;
			var r = 0;
			var intsMax = new int[ints.Count() + 1];
			ints.CopyTo(intsMax, 0);
			intsMax[intsMax.Count() - 1] = int.MaxValue;
			var ints1Max = new int[ints1.Count() + 1];
			ints1.CopyTo(ints1Max, 0);
			ints1Max[ints1Max.Count() - 1] = int.MaxValue;

			while (intsMax[i] < int.MaxValue || ints1Max[j] < int.MaxValue)
			{
				if (intsMax[i] <= ints1Max[j])
				{
					result[r++] = intsMax[i++];
				}
				if (intsMax[i] > ints1Max[j])
				{
					result[r++] = ints1Max[j++];
				}
				
			}
			return result;
		}
	}
}
