using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class HRQuickSearch
    {
        public static int arraySize;

       public static void Quicksort(int start, int end, int[] array)
        {
            if (start >= end)
                return;
            int p = Partition(start, end, array);
            Console.Write(p);
            // PrintArray(array);
            Quicksort(start, p-1, array);
            Quicksort(p + 1, end, array);
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
        }

        static int Partition(int start, int end, int[] array)
        {
            int pivot = array[end];
            array[end] = array[start];
            array[start] = pivot;

            int i = start + 1;
            for (int j = start+1; j <= end; j++)
            {
                if (array[j] < pivot)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                }
            }

            int temp1 = array[i-1];
            array[i - 1] = pivot;
            array[start] = temp1;

            return i-1;
        }
    }
}
