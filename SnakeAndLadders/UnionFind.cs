using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//To Detect Cycle in a graph
namespace SnakeAndLadders
{
    public class UnionFind
    {
        public int find(int[] parent,int k)
        {
            if (parent[k] == -1)
                return k;
            else return find(parent, parent[k]);
        }

        public int[] union(int[] parent,int x,int y)
        {
            int x1 = find(parent, x);
            int x2 = find(parent, y);
            parent[x1] = x2;
            return parent;
        }
        public bool isCycle(int[][] graph,int length)
        {
            int[] parent = Enumerable.Repeat(-1, length).ToArray();
            for(int i =0;i<length;i++)
            {
                for(int j =0;j<length;j++)
                {
                    if(graph[i][j] != 0)
                    {
                        int x1 = find(parent, i);
                        int x2 = find(parent, j);
                        if (x1 != x2)
                        {
                            parent = union(parent, i, j);
                            graph[j][i] = 0;
                        }
                        else
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
