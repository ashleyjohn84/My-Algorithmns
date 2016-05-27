using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        [Test]
        public void TestSki()
        {
            SingaporeSki obj = new SingaporeSki(4);
            int[][] input = new int[4][];
            input[0] = new int[] { 4, 8, 7, 3};
            input[1] = new int[] { 3, 4, 9, 3 };
            input[2] = new int[] { 2, 5, 8, 9};
            input[3] = new int[] { 1, 6, 7, 10 };
            int[] sdinput = new int[17];
            obj.CreateAdjacencyList(input);
            int c = 1;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    
                    sdinput[c] = input[i][j];
                    c++;
                }
                   
            }
            obj.DFS(new int[17], new bool[17],sdinput);

            
        }

        [Test]
        public void TestskiOnline()
        {
            var task = GetData("http://s3-ap-southeast-1.amazonaws.com/geeks.redmart.com/coding-problems/map.txt");
            string str = task.Result;
            string[] result = str.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
 
            SingaporeSki obj = new SingaporeSki(1000);
            int[][] input = new int[1000][];
            for (int i = 1; i <= 1000; i++)
            {
                input[i - 1] = Array.ConvertAll(result[i].Split(' '), Int32.Parse);
            }
            obj.CreateAdjacencyList(input);
            int[] sdinput = new int[1000*1000+1];
            int c = 1;
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {

                    sdinput[c] = input[i][j];
                    c++;
                }

            }
            obj.DFS(new int[1000 * 1000 + 1], new bool[1000 * 1000 + 1],sdinput);

          
        }

        private async Task<string> GetData(string address)
        {
            WebClient client = new WebClient();
            var task = await client.DownloadStringTaskAsync(address);
            return task;
        }

    }
}
