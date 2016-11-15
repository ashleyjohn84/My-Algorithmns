using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class Prims_MinimumSpanningTree
    {
        public void Prim(int[][] graph,int length)
        {
            bool[] visited = new bool[length];
            int[] parent = new int[length];
            int[] keys = Enumerable.Repeat(Int32.MaxValue, length).ToArray();
            keys[0] = 0;
            for(int i = 0; i < length; i++)
            {
                int pos = GetMinKey(keys, visited,length);

                visited[pos] = true;
                for(int j = 0; j < length; j++)
                {
                    if(graph[pos][j] != 0 && !visited[j] && graph[pos][j] < keys[j])
                    {
                        keys[j] = graph[pos][j];
                        parent[j] = pos;
                    }
                }

            }
        }

        private int GetMinKey(int[] keys, bool[] visited,int length)
        {
            int min = Int32.MaxValue;
            int pos = 0;
            for (int i = 0; i < length; i++)
            {
                if(!visited[i] && keys[i] < min)
                {
                    min = keys[i];
                    pos = i;
                }
            }
            return pos;
        }
    }
}
