using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class Permutation
	{
		private void Permutate(char[] chars, char[] forbidden, IList<string> results)
		{
			foreach (char c in chars.Where(c => !forbidden.Contains(c)))
			{
				var temp = new char[forbidden.Count() + 1];
				forbidden.CopyTo(temp, 0);
				temp[temp.Count() - 1] = c;

				Permutate(chars, temp, results);
			}

			if (forbidden.Count() == 4)
			{
				results.Add(new string(forbidden));
			}
		}

		[Test]
		public void CanPermutate()
		{
			var result = new List<string>();
			Permutate(new[] {'A', 'B', 'C', 'D'}, new char[0], result);
			Assert.AreEqual(24, result.Count());
		}
	}
}