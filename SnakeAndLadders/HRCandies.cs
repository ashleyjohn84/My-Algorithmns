using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class HRCandies
    {
        public int[] rating;

        public int[] candies;

        public HRCandies(int[] array)
        {
            rating = array;
        }

        public void Solve(int start,int end)
        {
            if (start >= end)
                return;
            else
            {
                int minIndex1 = GetLocalMin(start, end);
                candies[minIndex1] = 1;

            }
        }

        private int GetLocalMin(int start, int end)
        {
            int min = start;
            for (int i = start+1; i < end; i++)
            {
                if (rating[i] < rating[start])
                {
                    min = i;
                }
                else
                {
                    break;
                }
            }
            return min;
        }

    }
}
