using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    public class Stack
    {
        public int[] array = new int[10];

        public int Top { get; set; }

        public bool IsEmpty()
        {
            return Top == 0;
        }

        public void Push(int a)
        {
            if (Top < 10)
            {
                array[Top] = a;
                Top = Top + 1;
            }
            throw new Exception("Full");
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new Exception("Empty");
            Top = Top - 1;
            return array[Top];
        }
    }

    public class Queue
    {
        public const int capacity = 3;
        public int[] array = new int[capacity];

        public int head { get; set; }
        public int tail { get; set; }
        public int size;

        public Queue()
        {
           
        }

        public bool queueFull
        {
            get
            {
                if (size == capacity)
                    return true;
                return false;
            }
          
        }

        public bool queueEmpty
        {
            get
            {
                if ((size == 0))
                    return true;
                return false;
            }

        }

     

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int a)
        {
            if (!queueFull)
            {
                array[tail] = a;
                tail = (tail + 1) % capacity;
                size++;

            }
        }

        public int Dequeue()
        {
            if (!(queueEmpty))
            {
                int data = array[head];
                head = (head + 1) % capacity;
                size--;
                return data;
               
            }
            throw new Exception("Empty Queue");
        }

    }
}
