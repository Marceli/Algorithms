using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	class MyEnumerator:IEnumerable<int>
	{
		#region IEnumerable<int> Members

		public IEnumerator<int> GetEnumerator()
		{
			for(int i = 0;i<5;i++)
			{

				 yield return i;
			}
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		#endregion
	
	[Test]
	public void EnumeratorTest()
	{
		foreach(var olo in new MyEnumerator())
		{
			Debug.WriteLine(olo);
		}
	}

		
	[Test]
	public void EnumeratorTest2()
	{
		var enumerator=
		new MyEnumerator();
		var enumerator1 = ((IEnumerable) enumerator).GetEnumerator();
		while(enumerator1.MoveNext())
		{
			Debug.WriteLine(enumerator1.Current);
		}
		
	}
	
}

}
