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





                return 0;
            }
            int m1 = 0, m2 = 0, m3 = 0;
            if (!isDivisible(output, k, array[start]))
            {
                m3 = GetMaxmemo(array, k, output, start + 1, end, counter, maxList);
                if (!isDivisible(output, k, array[start]))
                {
                    output.Add(array[start]);
                    m1 = 1 + GetMaxmemo(array, k, output, start + 1, end, counter, maxList);
                }
            }
            else
            {
                m2 = GetMaxmemo(array, k, output, start + 1, end, counter, maxList);
            }
            int c = Math.Max(m1, m3);
            return Math.Max(c, m2);
            

        }

        public void GetMax(int[] array, int k, List<int> output, int start, int end, int counter)
        {
            string str = GetString(output);
            Console.WriteLine(str);
            if (start == end)
            {

                return;
            }
            output.Add(array[start]);
            GetMax(array, k, output, start + 1, end, counter);
            output.Remove(array[start]);
            GetMax(array, k, output, start + 1, end, counter);

            return;

        }

        private string GetString(List<int> output)
        {
            string opString = String.Empty;
            foreach (var str in output)
            {
                opString = opString + String.Format(" {0} ", str);
            }
            opString = opString + " * ";
            return opString;
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
