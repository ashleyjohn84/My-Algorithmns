using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class Dijkstra_ShortestPath
    {
        public int Dijkstra1(int[][] graph, int start)
        {
            int[] distance = Enumerable.Repeat(Int32.MaxValue, 10).ToArray();
            bool[] visited = new bool[10];
            int[] parent = new int[10];
            distance[start] = 0;
            parent[start] = start;
            for( int i = start; i < 9; i++ )
            {
                int pos = GetNearestNeigbourMod(distance,visited);
                visited[pos] = true;

                for (int j = 0; j < 9; j++)
                {
                    if (!(visited[j]) && (graph[pos][j] != 0) && distance[pos] < Int32.MaxValue &&
                        distance[j] > distance[pos] + graph[pos][j])
                    {
                        distance[j] = distance[pos] + graph[pos][j];
                        parent[j] = pos;
                    }
                }

            }
            return distance[9];

        }

        private int GetNearestNeigbourMod(int[] distance, bool[] visited)
        {
            int min = Int32.MaxValue;
            int pos = 0;
            for (int i = 0; i < 9; i++)
            {
                if (!visited[i] && distance[i] < min)
                {
                    pos = i;
                    min = distance[i];
                }
            }
            return pos;
        }


       
    }
}
