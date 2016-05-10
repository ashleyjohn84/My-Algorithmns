using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class HeapAlgorithmns
    {
        private int[] _array;

        public IEnumerable<int> list
        {
            get {return _array ; }
        }

        public HeapAlgorithmns(int[] array)
        {
            _array = array;
            Heapsize = _array.Length;
        }
        public int Heapsize { get; set; }

        public int ArrayLength
        {
            get { return _array.Length; }
        }
        public int Left(int i )
        {
            return 2*i+1;
        }
        public int Right(int i)
        {
            return (2 * i)+2;
        }

        public int Parent(int i)
        {
            return i/2;
        }
        public void Heapify(int i)
        {
            int left = Left(i);
            int right = Right(i);
            int temp;
            int largest = i;
            if ((left < Heapsize) && (_array[left] > _array[i]))
                largest = left;
            if ((right < Heapsize) && (_array[right] > _array[largest]))
                largest = right;
            if (largest != i)
            {
                temp = _array[largest];
                _array[largest] = _array[i];
                _array[i] = temp;

                Heapify(largest);
            }
        }

        public void BuildHeap()
        {
            for (int i = Heapsize / 2; i >= 0; i--)
            {
                Heapify(i);
            }
        }

        public void HeapSort()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                int temp = _array[0];
                _array[0] = _array[Heapsize - 1];
                _array[Heapsize - 1] = temp;
                Heapsize = Heapsize - 1;
                Heapify(0);
            }
        }
    }
}
