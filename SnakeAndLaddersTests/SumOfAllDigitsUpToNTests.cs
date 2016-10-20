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
    public class SumOfAllDigitsUpToNTests
    {
        [TestMethod()]
        public void sumofDigitsTest()
        {
           int x = SumOfAllDigitsUpToN.sumofDigits(328);
        }
    }
}