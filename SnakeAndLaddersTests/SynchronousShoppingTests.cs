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
    public class SynchronousShoppingTests
    {
        [TestMethod()]
        public void AddFishTest()
        {

            SynchronousShopping obj = new SynchronousShopping(5, 5, 5);
            for (int i = 1; i <= 5; i++)
                obj.AddFish(i, new int[] {1, i });
            int[][] roads = new int[][]
            {
               new int[] {1,2,10},
               new int[] {1,3,10},
               new int[] {2,4,10},
               new int[] {3,5,10},
               new int[] {4,5,10}
            };
            for(int i =0;i<5;i++)
            {
                obj.AddEdgeAtEnd(roads[i][0], roads[i][1], roads[i][2]);
                obj.AddEdgeAtEnd(roads[i][1], roads[i][0], roads[i][2]);
            }
            obj.ShortestPath();
        }
    }
}