using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders.Tests
{
    [TestClass()]
    public class CoinChangeProblemTests
    {
        [TestMethod()]
        public void GetCountOfSolutionsTest()
        {
            CoinChangeProblem obj = new CoinChangeProblem();
            int[] array = new int[] {1,2,3 };
            var c = obj.GetCountOfSolutions(array, 3, 4);
        }

        [TestMethod()]
        public void GetCountOfSolutionsTest1()
        {
            CoinChangeProblem obj = new CoinChangeProblem();
            int[] array = new int[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40,
                2, 43, 49, 46, 19, 41, 1, 12, 11, 28 };
            var c = obj.GetCountOfSolutions1(array, 23, 166);
        }

        [TestMethod()]
        public void GetCountOfSolutionsTest2()
        {
            CoinChangeProblem obj = new CoinChangeProblem();
            int[] array = new int[] { 1,2};
            var c = obj.GetCountOfSolutions(array, 2, 3);
        }
    }
}