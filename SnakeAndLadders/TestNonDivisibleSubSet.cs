using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    public class TestNonDivisibleSubSet
    {
        [Test]
        public void Test1()
        {
            int[] array = new[] {7,1,4,2};
            NonDivisibleSubSet obj = new NonDivisibleSubSet();
            List<int> output = Enumerable.Repeat(-1, array.Length + 1).ToList();
            List<int> maxList = Enumerable.Repeat(-1, array.Length + 1).ToList();
            int c = obj.GetMaxmemo(array, 3, output, 0, 4, 0, maxList.ToArray());

        }
    }
}
