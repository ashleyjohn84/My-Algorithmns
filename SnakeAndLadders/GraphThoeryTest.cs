using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class GraphThoeryTest
    {
        [Test]
        public void TestGraph()
        {
            int vertices = 5;
            GraphTheory obj = new GraphTheory(vertices);
            int edges = 5;
            obj.AddEdgeAtEnd(0, 4, 1);
            obj.AddEdgeAtEnd(0, 3, 1);
            obj.AddEdgeAtEnd(1, 2, 1);
            obj.AddEdgeAtEnd(1, 4, 1);
            obj.AddEdgeAtEnd(2, 3, 1);
            obj.AddEdgeAtEnd(4, 2, 1);
            obj.PrintAdjacencyList();
            obj.BFS(2,new int[5],new int[5] );

        }

        [Test]
        public void TestSnakeAndLadders()
        {
            int vertices = 101;
            GraphTheory obj = new GraphTheory(101);
            List<Tuple<int,int>> edjes = new List<Tuple<int, int>>();
            edjes.Add(new Tuple<int, int>(8,52));
            edjes.Add(new Tuple<int, int>(6, 80));
            edjes.Add(new Tuple<int, int>(26, 42));
            edjes.Add(new Tuple<int, int>(2, 72));

            edjes.Add(new Tuple<int, int>(51, 19));
            edjes.Add(new Tuple<int, int>(39, 11));
            edjes.Add(new Tuple<int, int>(37, 29));
            edjes.Add(new Tuple<int, int>(81, 3));
            edjes.Add(new Tuple<int, int>(59, 5));
            edjes.Add(new Tuple<int, int>(79, 23));
            edjes.Add(new Tuple<int, int>(53, 7));
            edjes.Add(new Tuple<int, int>(43,33));
            edjes.Add(new Tuple<int, int>(77, 21));

            obj.CreateAdjacencyList(edjes);
            obj.PrintAdjacencyList();
            int c =obj.BFS(100, new int[101], new int[101]);

        }

      

    }
}
