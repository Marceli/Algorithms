using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class FizzBuzz
    {
        [Test]
        public void DoFizzBuzz()
        {
            Enumerable.Range(1,100).ToList().ForEach(el=>Console.WriteLine(Fizz(el)));
        }
       string Fizz(int i)
        {
            if (i % 3==0 && i % 5==0)
                return "FizzBuzz";
            if (i % 3==0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";
            return i.ToString();
        }
    }
}
