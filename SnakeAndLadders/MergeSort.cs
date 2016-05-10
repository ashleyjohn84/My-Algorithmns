using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class MergeSort
    {
        public int[] list;

   
        private int[] output;

        public int[] Sort(int start, int end)
        {
            if (start >= end)
                return new int[1] {list[start]};
            int middle = start + (end - start)/2;
            int[] left=Sort(start, middle);
            int[] right=Sort(middle+1,end);
            return Merge(left,right);
        }

        public int[] Merge(int[] left,int[] right)
        {
      
                
            int start1 =0, start2 = 0;
            int end1 = left.Length - 1;
            int end2 = right.Length - 1;
            output = new int[left.Length+right.Length];
            int i = 0;
            while (start1 <= end1 && start2 <= end2)
            {
                if (left[start1] < right[start2])
                {
                    output[i] = left[start1];
                    start1++;
                }
                else
                {
                    output[i] = right[start2];
                    start2++;
                }
                i++;
            }
          
                while (start1 <= end1)
                {
                    output[i] = left[start1];
                    start1++;
                    i++;
                }
            
            while (start2 <= end2)
            {
                output[i] = right[start2];
                start2++;
                i++;
            }
            return output;
        }
    }
}
