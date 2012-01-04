using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class InheritanceAndConstruktors
    {
        [Test]
        public void ConstructorOrderTest()
        {
            var olo = new C();
        }
        [Test]
        public void CallingVirtualMethodInsideConstructorTest()
        {
            var olo = new C();
        }

    }

    internal class A
    {
        public virtual void M()
        {
           Debug.WriteLine("Inside method M of classs A"); 
        }
        public A()
        {
            M();
            Debug.WriteLine("Performing consruktor for class A");
        }
    }

    internal class B:A
    {
        public override void M()
        {
           Debug.WriteLine("Inside method M of classs B"); 
        }
        public B()
        {
            Debug.WriteLine("Performing consruktor for class B");
        }
    }

    internal class C : B
    {
        public override void M()
        {
           Debug.WriteLine("Inside method M of classs C"); 
        }
        public C()
        {
            Debug.WriteLine("Performing consruktor for class C");
        }
    }
}
