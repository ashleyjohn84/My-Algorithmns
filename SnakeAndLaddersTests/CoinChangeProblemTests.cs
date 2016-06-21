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
    }
}