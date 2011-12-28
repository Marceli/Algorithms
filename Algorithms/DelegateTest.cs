using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
	[TestFixture]
	class DelegateTest
	{
		public delegate void myDel();

		private myDel reference;
		[Test]
		public void StaticDelegateTest()
		{
			reference += DelegateBasic.SayYourName;
			reference();
		}
		[Test]
		public void InstanceDelegateTest()
		{
			var delegateBasic = new DelegateBasic();
			reference += delegateBasic.SayYourNameInstance;
			reference();
		}
		[Test]
		public void MuliticastDelegateTest()
		{
			var delegateBasic = new DelegateBasic();
			reference += delegateBasic.SayYourNameInstance;
			
			reference += DelegateBasic.SayYourName;
			reference();
		}

	}
	class DelegateBasic
	{
		public static void SayYourName()
		{
			Console.WriteLine("Marcel");
		}
		public void SayYourNameInstance()
		{
			Console.WriteLine("Instance Marcel");
		}
	}
}
