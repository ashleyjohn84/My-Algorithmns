using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class StackTest
    {
        [Test]
        public void TestStackOperations()
        {
            Stack obj = new Stack();
            for(int i =0 ;i< 10;i++)
                obj.Push(i*2);
            var ex = Assert.Catch<Exception>(() => obj.Push(5));
            Assert.That(ex.Message,Is.EqualTo("Full"));
        }

        [Test]
        public void TestQueueOperations()
        {
            Queue obj = new Queue();
            for (int i = 0; i < 3; i++)
                obj.Enqueue(i * 2);
        
            Enumerable.Range(1,5).ToList().ForEach((y) => obj.Dequeue());
            Enumerable.Range(1, 3).ToList().ForEach((y) => obj.Enqueue(y*3));
            Enumerable.Range(1, 7).ToList().ForEach((y) => obj.Dequeue());
            var x = obj.Dequeue();
            Assert.AreEqual(0,x);
        }

        [Test]
        public void TestQueueOperations1()
        {
            CircularArrayQueue obj = new CircularArrayQueue(3);
            for (int i = 0; i < 10; i++)
                obj.enqueue(i * 2);

            Enumerable.Range(1, 5).ToList().ForEach((y) => obj.dequeue());
            Enumerable.Range(1, 3).ToList().ForEach((y) => obj.enqueue(y * 3));
            Enumerable.Range(1, 7).ToList().ForEach((y) => obj.dequeue());
            var x = obj.dequeue();
            Assert.AreEqual(0, x);
        }
    }
}
