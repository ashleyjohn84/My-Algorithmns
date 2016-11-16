using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAndLadders;

namespace SnakeAndLaddersTests
{
    [TestClass]
    public class Dijkstra_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] graph = new int[][]{
                                  new int[]{0, 4, 0, 0, 0, 0, 0, 8, 0},
                                  new int[]{4, 0, 8, 0, 0, 0, 0, 11, 0},
                                  new int[]{0, 8, 0, 7, 0, 4, 0, 0, 2},
                                  new int[]{0, 0, 7, 0, 9, 14, 0, 0, 0},
                                  new int[]{0, 0, 0, 9, 0, 10, 0, 0, 0},
                                  new int[]{0, 0, 4, 14, 10, 0, 2, 0, 0},
                                  new int[]{0, 0, 0, 0, 0, 2, 0, 1, 6},
                                  new int[] {8, 11, 0, 0, 0, 0, 1, 0, 7},
                                  new int[]{0, 0, 2, 0, 0, 0, 6, 7, 0}
                                 };
            Dijkstra_ShortestPath t = new Dijkstra_ShortestPath();
            t.Dijkstra1(graph, 0);
        }

        [TestMethod]
        public void TestMethod2_Prim()
        {
            int[][] graph = new int[][]{
                                  new int[]{0, 2, 0, 6, 0},
                                  new int[]{2, 0, 3, 8, 5},
                                  new int[]{0, 3, 0, 0, 7},
                                  new int[]{6, 8, 0, 0, 9},
                                  new int[]{0, 5, 7, 9, 0}
                                 };
            Prims_MinimumSpanningTree t = new Prims_MinimumSpanningTree();
            t.Prim(graph,graph.Length);
        }

        [TestMethod]
        public void TestMethod2_IsCycle()
        {
            int[][] graph = new int[][]{
                                  new int[]{0, 2, 0, 6, 0},
                                  new int[]{2, 0, 3, 8, 5},
                                  new int[]{0, 3, 0, 0, 7},
                                  new int[]{6, 8, 0, 0, 9},
                                  new int[]{0, 5, 7, 9, 0}
                                 };
            UnionFind t = new UnionFind();
            t.isCycle(graph, graph.Length);
        }
    }
}
