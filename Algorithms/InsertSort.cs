using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class InsertSort
	{
		[Test]
		public void CanSort()
		{
			Assert.AreEqual(new int[] {1, 2, 3, 4}, Sort(new[] {4, 3, 2, 1}));
			Assert.AreEqual(new int[] { 1, 2, 3, 4,5,6 }, Sort(new[] { 4, 6,3, 2,5, 1 }));
		}

		private int[] Sort(int[] ints)
		{
			for (int i = 1; i < ints.Count(); i++)
			{
				int j = i;
				while (j > 0 && ints[j-1]>ints[j])
				{
					
					int temp = ints[j-1];
					ints[j-1] = ints[j];
					ints[j] = temp;
					j = j - 1;

				}
				
			}
			return ints;
		}
	}
}
