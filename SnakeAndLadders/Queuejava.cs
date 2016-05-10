using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class CircularArrayQueue {
     
    private static  int capacity = 5;
    private Object[] Q;
    private  int N; // capacity
    private int f = 0;
    private int r = 0;


        public CircularArrayQueue()
        {
        }


      public CircularArrayQueue(int capacity){
        N = capacity;
        Q = new Object[N];
    }
 
    public int size() {
        if(r > f)
            return r - f;
        return N - f + r;
    }
 
    public bool isEmpty() {
        return (r == f) ? true : false;
    }
 
    public bool isFull() {
        int diff = r - f; 
        if(diff == -1 || diff == (N -1))
            return true;
        return false;
    }
 
    public void enqueue(Object obj)  {
        if(isFull()){
            throw new Exception("Queue is Full.");
        }else{
            Q[r] = obj;
            r = (r + 1) % N;
        }
    }
 
    public Object dequeue()  {
        Object item; 
        if(isEmpty()){
            throw new Exception();
        }else{
            item = Q[f];
            Q[f] = null;
            f = (f + 1) % N;
        }
       return item;
    }
 
}
}
