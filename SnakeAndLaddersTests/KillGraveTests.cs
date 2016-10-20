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
    public class KillGraveTests
    {
        [TestMethod()]
        public void InitTest()
        {
            KillGrave.N = 3;
            KillGrave.M = 2;
            KillGrave.money = new int[] { 6, 8, 2 };
            KillGrave.roads = new int[,] { { 0, 1 }, { 1, 0 }, { 2, 1 }, { 1, 2 } };
            KillGrave.Start();
        }
    }
}