using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class TestLinkedList
    {
        [Test]
        public void TestPrint()
        {
            LinkedListOperations obj = new LinkedListOperations();
            Node head = obj.CreateLinkedList();
            //obj.PrintList(head);
            Console.WriteLine();
            //obj.PrintReverse(head);
           Node newHead= obj.ReverseLinkedList(head, null);
        }

        [Test]
        public void TestJosepheusCircle()
        {
            LinkedListOperations obj = new LinkedListOperations();
            Node head = obj.CreateLinkedList(true);
            int data = obj.JosepheusCircle(head);
        }

        [Test]
        public void TestReverseinPairs()
        {
            LinkedListOperations obj = new LinkedListOperations();
            Node head = obj.CreateLinkedList();
            obj.PrintList(head);
            Console.WriteLine(String.Format("{0,10:C}", "13"));
            Node neHead= obj.ReverseInPairs(head);
            obj.PrintList(neHead);
        }
    }
}
