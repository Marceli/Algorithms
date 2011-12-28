using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class LambdaTest
    {
        [Test]
        public void Test()
        {
            var names = new[] {"Janek", "Branek", "Wojtek"};
            var olo = from name in names select name.Length;
            olo.ToList().ForEach(Console.WriteLine);
        
        
        }
    }
}
