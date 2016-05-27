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
            int[] array = new[] {7,1};
            NonDivisibleSubSet obj = new NonDivisibleSubSet();
            //List<int> output = Enumerable.Repeat(-1, array.Length + 1).ToList();
            List<int> output = new List<int>();
            List<int> maxList = Enumerable.Repeat(-1, array.Length + 1).ToList();
            obj.GetMax(array, 3, output, 0, 2, 0);

        }
    }
}
