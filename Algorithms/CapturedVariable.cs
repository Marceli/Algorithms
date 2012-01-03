using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class CapturedVariable
	{
		public void Test()
		{
			IEnumerable<char> query = "Not what you might expect"; 
			foreach (char vowel in "aeiou")   
			{
			var temp=vowel;
				query = query.Where (c => c != temp); 
			}
				foreach (char c in query) Debug.Write (c);   
		
		}
		[Test]
		public void Test1()
		{
			IEnumerable<char> query = "Not what you might expect"; 
			foreach (char vowel in "aeiou")   
			{

				query = query.Where(c => c != vowel); 
			}
				foreach (char c in query) Debug.Write (c);   
		
		}
	}
}
