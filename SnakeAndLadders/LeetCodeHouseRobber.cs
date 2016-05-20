using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/house-robber/

namespace SnakeAndLadders
{
   
    class LeetCodeHouseRobber
    {
        public static  int count = 0;

        public static  int SolveDP(int[] array,int start,int end,int[] output)
        {
            count++;
            if (start == end)
            {
                output[start] = array[end];
                return array[end];
            }
            if (start > end)
            {
               
                output[start] = 0;
                return 0;
            }
            else
            {
                int m1 = array[start] +
                         (output[start + 2] != -1 ? output[start + 2] : SolveDP(array, start + 2, end, output));
                int m2 = output[start + 1] != -1 ? output[start + 1] : SolveDP(array, start + 1, end, output);
                output[start] = Math.Max(m1, m2);
                return output[start];
            }
        }

        public static int Solve(int[] array, int start, int end)
        {
            count++;
            if (start == end)
                return array[end];
            if (start > end)
                return 0;
            else
            {
                int m1 = array[start] +  Solve(array, start + 2, end);
                int m2 =  Solve(array, start + 1, end);
                return Math.Max(m1, m2);
            }
        }
    }
}
