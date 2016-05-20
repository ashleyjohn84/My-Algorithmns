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

        [Test]
        public void TestHouseRobber()
        {
            int[] main = new int[] { 114, 117, 207, 117, 235, 82, 90, 67, 143, 146, 53, 108, 200, 91, 80, 223, 58, 170, 110, 236, 81, 90, 222, 160, 165, 195, 187, 199, 114, 235, 197, 187, 69, 129, 64, 214, 228, 78, 188, 67, 205, 94, 205, 169, 241, 202, 144, 240 };
           // int[] main = new int[]{1,5,8,6};
              List<int> output = Enumerable.Repeat(-1, main.Length+1).ToList();
              int s = LeetCodeHouseRobber.SolveDP(main, 0, main.Length-1,output.ToArray());
              int s1 = LeetCodeHouseRobber.Solve(main, 0, main.Length-1);

        }
    }
}
