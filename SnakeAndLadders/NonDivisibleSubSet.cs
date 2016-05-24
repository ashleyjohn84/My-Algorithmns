using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class NonDivisibleSubSet
    {
        public int GetMaxmemo(int[] array, int k, List<int> output, int start, int end, int counter,int[] maxList)
        {
            string str = String.Format("Calling Start {0} End {1}", start, end);
            Console.WriteLine(str);
            if (start == end )
            {
               
                
                maxList[start] = 0;
                

                return maxList[start];
            }
            int m1 = 0, m2 = 0, m3 = 0;
            if (!isDivisible(output, k, array[start]))
            {
                m3 = (maxList[start + 1] != -1 ? maxList[start + 1] : GetMaxmemo(array, k, output, start + 1, end, counter, maxList));
                if (!isDivisible(output, k, array[start]))
                {
                    output.Add(array[start]);
                    m1 = 1 +
                         (maxList[start + 1] != -1
                             ? maxList[start + 1]
                             : GetMaxmemo(array, k, output, start + 1, end, counter, maxList));
                }
            }
            else
            {
                m2 = (maxList[start + 1] != -1 ? maxList[start + 1] : GetMaxmemo(array, k, output, start + 1, end, counter, maxList));
            }
            int c = Math.Max(m1, m3);
            maxList[start] = Math.Max(c, m2);
            return maxList[start];

        }

        public int GetMax(int[] array, int k, int[] output, int start, int end, int counter)
        {
            string str = String.Format("Calling Start {0} End {1}", start, end);
            Console.WriteLine(str);
            if (start == end - 1)
            {

                return 1;
            }
            int m1 =  GetMax(array, k, output, start + 1, end, counter);
            int m2 = GetMax(array, k, output, start + 1, end, counter);
            return Math.Max(m1, m2);

        }




        public bool isDivisible(List<int> array, int k, int value)
        {
            foreach (int a in array)
            {
                if ((a != -1) && ((a + value) % k == 0))
                    return true;
            }
            return false;
        }
    }
}
