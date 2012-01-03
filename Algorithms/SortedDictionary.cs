using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class SortedDictionaryTest
	{
		[Test]
		public void Mytest()
		{
			var sortedDictionary = new SortedDictionary<string,int>();
			sortedDictionary["Ala"] = 12;
			sortedDictionary["zigi"] = 8;
			sortedDictionary["bolo"] = 7;
			foreach(var value in sortedDictionary)
			{
				Debug.WriteLine(value.Key + ";" + value.Value);
			}
		}
	}
}
