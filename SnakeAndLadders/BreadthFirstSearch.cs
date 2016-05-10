using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class GraphTheory
    {
        private LinkedList<Tuple<int, int>>[] adjacencyList;
        private Queue<int>  queue;

        public GraphTheory(int vertices)
        {
            adjacencyList = new LinkedList<Tuple<int, int>>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
        }

        public int BFS(int v,int[] level,int[] parent)
        {
            queue = new Queue<int>();
            queue.Enqueue(1); //enqueue root
            int currentLevel = 0;
            bool[] visited = new bool[101];
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (visited[node])
                {
                    continue;
                }
                else
                {
                    visited[node] = true;

                    if (node == v)
                        return level[node];
                    else
                    {
                        foreach (var list in adjacencyList[node])
                        {
                            queue.Enqueue(list.Item1);
                            level[list.Item1] = (level[list.Item1] == 0)
                                ? level[node] + 1
                                : Math.Min(level[list.Item1], level[node] + 1);
                            parent[list.Item1] = node;
                        }
                    }

                }
            }
            return - 1;
        }

        public void AddEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }

        public void AddEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }

        public void CreateAdjacencyList(List<Tuple<int, int>> list)
        {
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    int endVertex = i + j;
                    if (i + j > 100)
                        break;
                    if (list.Any(x => x.Item1 == i+j))
                    {
                        endVertex = list.First(x => x.Item1 == i+j).Item2;
                    }
                    AddEdgeAtBegin(i, endVertex, 1);
                }
            }
        }


        public void PrintAdjacencyList()
        {
            int i = 0;
            foreach (var linkedList in adjacencyList)
            {
                Console.Write("Adjacency List["+i+ "] -> ");
                foreach (var edge in linkedList)
                {
                    Console.Write(edge.Item1 + "("+edge.Item2+")");
                }
                i++;
                Console.WriteLine();
            }
        }

    }
}
