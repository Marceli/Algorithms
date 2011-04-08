using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class Fibonacci
	{
		public int GetFibonacci(int value)
		{
			int fibonaci0 = 0;
			int fibonaci1 = 1;
			int fibonaci=0;
			if (value < 0)
				throw new ArgumentOutOfRangeException("Positive integers please");
			if (value == 0)
				return fibonaci0;
			if (value == 1)
				return fibonaci1;
			for(int i=2;i<=value;i++)
			{
				fibonaci = fibonaci0 + fibonaci1;
				fibonaci0 = fibonaci1;
				fibonaci1 = fibonaci;
			}
			return fibonaci;

		}
		[Test]
		public void GetFibonaciTest()
		
		{
			Assert.AreEqual(1, GetFibonacci(2));
			Assert.AreEqual(5, GetFibonacci(5));
			Assert.AreEqual(55, GetFibonacci(10));
			Assert.AreEqual(144, GetFibonacci(12));
		}
	}
}
