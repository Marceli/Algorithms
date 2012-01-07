using System;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class WhyInitializersRunOpositeOrderThanConstructors
    {
        [Test]
        public void InitrializersVsConsructorsTest()
        {
            var olo = new Derivied();
        }
    }

    class Foo
    {
         public Foo(string message)
         {
             Console.WriteLine(message);
         }
    }
    class Base
    {
        Foo baseFoo=new Foo("Initializer from Base class.");
        public Base()
        {
            Console.WriteLine("Base class constructor");
        }
    }
    class Derivied:Base

    {
        Foo deriviedFoo=new Foo("Initializer from derivied class.");
        public Derivied()
        {
            Console.WriteLine("Derivied class constructor");
        }
    }
}