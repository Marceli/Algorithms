using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Algorithms
{
    [TestFixture]
    public class ThreadSafeList
    {
        MyList list=new MyList();
        public void Adding()
        {
            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);

                
            }
            
        }
        public void Removing()
        {

            for (int i = 0; i < 100000; i++)
            {
                list.Remove(i);
            }
        }

        [Test]
        public void Test()
        {
            Parallel.Invoke(()=>Adding(),()=>Removing());
            Console.WriteLine(list.Count());
        
            
        }
    }
    public class MyList
    {
        List<int> list=new List<int>();
        public void Add(int el)
        {
            lock (list)
            {
                list.Add(el);
            }
        }
        public void Remove(int valueToRemove)
        {
            lock (list)
            {
                if(list.Contains(valueToRemove))
                    list.RemoveAt(list.IndexOf(valueToRemove));
            }
        }
        public int this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }


        internal int Count()
        {
            return list.Count;
        }
    }
}
