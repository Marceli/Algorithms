using System;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class Fibonacci
	{
		public int GetFibonacci(int value)
		{
			int previous = 0;
			int current = 1;
			int next=0;
			if (value < 0)
				throw new ArgumentOutOfRangeException("Positive integers please");
			if (value == 0)
				return previous;
			if (value == 1)
				return current;
			for(int i=2;i<=value;i++)
			{
				next = previous + current;
				previous = current;
				current = next;
			}
			return next;

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
