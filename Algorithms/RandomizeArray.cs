using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class RandomizeArray
	{
		[Test]
		public void CanRandomizeArray()
		{
			var result=Randomize(new[] {1, 2, 3, 4});
			PrintArray(result);

		}

		private int[] Randomize(int[] ints)
		{
			var random = new Random(Environment.TickCount);
			for (var i = 0; i < ints.Count();i++ )
			{
				var toReplace = random.Next(0, ints.Count());
				var temp = ints[i];
				ints[i] = ints[toReplace];
				ints[toReplace] = temp;
			}
			return ints;
		}
		private void PrintArray(int[] ints)
		{
			foreach (var i in ints)
			{
				Console.Write(i);
			}
			Console.WriteLine();
		}
	}
}
