using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public enum PivotAlgo
    {
        low,
        high,
        middle
    }

    public class QuickSort
    {
        private int[] _array;
        public int comparisons;
        public QuickSort(int[] array)
        {
            _array = array;
            comparisons = 0;
        }

        public int[] Array
        {
            get { return _array; }
        }

        public void Sort(int p, int q)
        {
            if (p >= q)
                return;
            int r = partition(p, q);
            Sort(p,r-1);
            Sort(r+1,q);
        }

        public int partition(int p, int q)
        {
            int pos = getPivotPos(p, q, PivotAlgo.middle);
            int temp;
            //replace pivot with first element
            temp = _array[p];
            _array[p] = _array[pos];
            _array[pos] = temp;

            pos = p;

            int j = p+1 ;
            
            for (int i = p+1 ; i <= q; i++)
            {
                comparisons++;
                if (_array[i] <= _array[pos])
                {
                    temp = _array[i];
                    _array[i] = _array[j];
                    _array[j] = temp;
                    j=j + 1;
                }
            }
            temp = _array[j-1];
            _array[j-1] = _array[pos];
            _array[pos] = temp;
            return j-1;
        }

        public int getPivotPos(int p, int q,PivotAlgo algo )
        {
            int pos=0;
            switch (algo)
            {
                    case PivotAlgo.high:
                    pos = q;
                    break;
                    case PivotAlgo.low:
                    pos = p;
                    break;
                    case PivotAlgo.middle:
                    pos = (p + q)/2;
                    break;
            }
            return pos;
        }


    }
}
