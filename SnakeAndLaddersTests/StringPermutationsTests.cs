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
    public class StringPermutationsTests
    {
        [TestMethod()]
        public void PrintCombinationsTest()
        {
            StringPermutations.PrintCombinations("abcd", 2);
        }
    }
}