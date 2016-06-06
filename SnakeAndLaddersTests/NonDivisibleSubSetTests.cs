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
    public class NonDivisibleSubSetTests
    {
        [TestMethod()]
        public void GetMaxTest()
        {
            int[] array = new[] { 7, 1,5 ,6};
            NonDivisibleSubSet obj = new NonDivisibleSubSet();
            //List<int> output = Enumerable.Repeat(-1, array.Length + 1).ToList();
            List<int> output = new List<int>();
            obj.GetMax(array, 3, output, 0, 4, 0);
        }
    }
}