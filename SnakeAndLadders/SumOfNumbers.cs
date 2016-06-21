using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
// Check if sum of a few elements(subset) match up to a number
namespace SnakeAndLadders
{
    public class SumOfNumbers
    {
        private static int counter = 0;
        public static bool isPossible(int[] array, int currentSum, int finalSum, int start, int end)
        {
            counter++;
            if (currentSum == finalSum)
                return true;
            if (start == end)
                return false;
            var a = isPossible(array, currentSum + array[start], finalSum, start + 1, end);
            var b = isPossible(array, currentSum, finalSum, start + 1, end);
            return a || b;
        }


        public static bool  IsPossibleDP(int[] array,int Sum,int n)
        {
            bool[,] result = new bool[Sum + 1, n+1];
            for(int i = 0; i <= n; i++)
            {
                result[0, i] = true;
            }
            for (int i = 1; i <= Sum; i++)
            {
                result[i, 0] = false;
            }

            for(int i = 1; i <= Sum; i++)
            {
                for(int j =1; j <= n; j++)
                {
                    result[i, j] = result[i, j - 1];
                    if (i >= array[j - 1])
                        result[i, j] = result[i, j] || result[i - array[j - 1], j - 1];
                }
            }

            return result[Sum, n];

        }

       
    }

    [TestFixture]
    public class TestNumber1
    {
        [Test]
        public void Test()
        {
            int[] array = new[] {5, 3, 2,1,2,1,1,0,3,2};
            var c = SumOfNumbers.isPossible(array, 0, 21, 0, 10);
        }
    }
}
