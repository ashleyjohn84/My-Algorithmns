using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
// Check if sum of a few elements match up to a number
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
