using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
    }
    public class LinkedListOperations
    {
        public Node CreateLinkedList(bool circular=false)
        {
            Node temp, head = null;
            Node node = null;
            for (int i = 0; i < 20; i++)
            {
                temp = node;
                node = new Node() {Data = (i+1)};
                if (i == 0)
                    head = node;
                else
                {
                    temp.Next = node;
                }
               
            }
            if (circular)
                node.Next = head;
            return head;
        }

        public void PrintList(Node head)
        {
            while (head != null)
            {
                Console.Write(head.Data+" -> ");
                head = head.Next;
            }
        }

        public void PrintReverse(Node head)
        {
            if (head != null)
            {
                PrintReverse(head.Next);
                Console.Write(head.Data + " -> ");
            }

        }

        public Node ReverseLinkedList(Node head,Node prev)
        {
            Node current = head;
            Node temp;
            if (current != null)
            {
                temp = current.Next;
                current.Next = prev;
                prev=ReverseLinkedList(temp, current);
            }
            return prev;
        }

        public int JosepheusCircle(Node head)
        {
            int i = 0;
            Node temp = head;
            while (temp.Next != null)
            {
                for(int k=1;k<8;k++)
                temp = temp.Next;
                i++;

                    Node skip = temp.Next;
                if (skip == null)
                    break;
                    temp.Next = skip.Next;
                skip.Next = null;

            }
            return temp.Data;
        }


        public Node ReverseInPairs(Node head)
        {
            Node next, prev = null;
            Node current = head;
            Node newHead = null;
            while (current != null && current.Next != null)
            {
                next = current.Next.Next;
                current.Next.Next = current;
                if (prev != null)
                    prev.Next = current.Next;
                else
                {
                    newHead = current.Next;
                }
                current.Next = next;
                prev = current;
                current = next;
            }
            return newHead;
        }
    }
}
