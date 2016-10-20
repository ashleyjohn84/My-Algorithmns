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
    public class SumOfNumbersTests
    {
        [TestMethod()]
        public void IsPossibleDPTest()
        {
            int[] input = new int[] { 1, 3, 6,4 };
            var output = SumOfNumbers.IsPossibleDP(input, 8, 4);
        }
    }
}