using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class TestTowers
    {
        [Test]
        public void TestNoOfSteps()
        {
            TowersOfHanoi obj = new TowersOfHanoi();
            obj.GetSteps(10, "A", "C","B");
        }

        [Test]
        public void TestMergeSort()
        {
            MergeSort obj = new MergeSort() {list = new[] {5, 7, 3, 9,12,67,31,14}};
            var output =obj.Sort(0, 7);
        }

        [Test]
        public void TestArrayContainsAnotherArray()
        {
            ArrayContainsAnotherArray obj = new ArrayContainsAnotherArray();
            int[] main = new int[]{1, 5, 8, 3, 2, 5, 6, 3, 5, 1, 9, 55, 2, 1,6,4,3,3,3,2,4,5,6,9};
            int[] sub = new int[] {6, 5, 9};
            int window = obj.Function(main, sub);
        }
    }
}
