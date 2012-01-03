using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class ReverseLinkedList
    {
        public Node Reverse(Node root)
        {
            Node current = root;
            Node previous = null;
            Node tmp = null;
            while (current!=null)
            {
                tmp = current;
                current = current.Next;
                tmp.Next=previous;
                previous = tmp;

            }
            return previous;
        }
        [Test]
        public void ReverseTest()
        {
            var node1 = new Node() {Data = 3,Next = null};
            var node2 = new Node() {Data = 2,Next = node1};
            var node3 = new Node() {Data = 1,Next = node2};
            Assert.AreEqual(3,node3.Next.Next.Data);
            var olo = Reverse(node3);
            Assert.AreEqual(1,Reverse(node3).Next.Next.Data);
        }
    }

    public class Node
    {
        public Node Next { get; set; }
        public int Data { get; set; }

    }
}
