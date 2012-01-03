using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	public class ComplementaryArray
	{
		[Test]
		public void MyTest()
		{
			Assert.AreEqual(7,FindCoplementaryElements(6, new int[] {1, 8, -3, 0, 1, 3,-2,4,5}));
			Assert.AreEqual(7, FindCoplementaryElements2(6, new int[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 }));
			Assert.AreEqual(7, FindComplementary(6, new int[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 }));
			Assert.AreEqual(7, FindComplementary2(6, new int[] { 1, 8, -3, 0, 1, 3, -2, 4, 5 }));
			Assert.AreEqual(8, FindComplementary2(6, new int[] { 1, 2, 3,3, 4, 5 }));
			Assert.AreEqual(8, FindCoplementaryElements(6, new int[] { 1, 2, 3, 3, 4, 5 }));
			//1 A[1]=8 A[2]=-3 A[3]=0 A[4]=1 A[5]=3 A[6]=-2A[7]=4 A[8]=5
		}

		
		public int FindComplementary2(int k, int[] a)
		{
			var count = new Dictionary<int, int>();
			foreach(var e in a)
			{
				if (!count.ContainsKey(e))
					count.Add(e, 1);
				else
					count[e]++;
			}
			int result = 0;
			foreach(var e in a)
			{
				if(count.ContainsKey(k-e))
				{
					result += count[k - e];
				}
			}
			return result;
		
		}
		public static int FindComplementary(int k, int[] a)
		{
			int test = 0;
			for (int i = 0; i < a.Length; i++)
			{
				int tested = k - a[i];
				var results = Array.FindAll(a, e=>e==tested);
				test += results.Length;
			}
			return test;
		}


		public int FindCoplementaryElements2(int k, int[] a)
		{
			
			int result = 0;
			Array.Sort(a);
			for (int i = 0; i < a.Length ; i++)
			{
				int tofind = k - a[i];
				var found = Array.BinarySearch(a,tofind);
				if (found >= 0)
				{
					Console.WriteLine("method 2 low:{0}  high{1}",  a[i],a[found]);
					result++;
					int j =  1;
					while (found+j<a.Length && a[found + j++] == tofind)
						result++;
					j = - 1;
					while (found + j>=0 && a[found + j--] == tofind)
						result++;

				}
			}
			return result;
		}

		public int FindCoplementaryElements(int k, int[] a)
		{
			Array.Sort(a);

			
			
			int l = 0;
			int h = a.Length - 1;
			int result = 0;
			
			while(l<=h)
			{
				if (a[l] + a[h] == k)
				{
					
					
					Console.WriteLine("low:{0}   high{1}",a[l],a[h]);
					result++;
					if (l != h)
						result++;
					
					if(a[l]==a[l+1])
					{
						l++;
						continue;
					}
					if (a[h] == a[h - 1])
					{
						h--;
						continue;
					}
					l++;	
					h--;

				}
				else
				{
					if (a[l] + a[h] < k)
						l++;
					else
						h--;
				}

			}
			return result;


		}
	}
}
