using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

/*https://www.hackerrank.com/contests/w20/challenges/synchronous-shopping */
namespace SnakeAndLadders
{
    public class SynchronousShopping
    {
        public int cities;
        public int roads;
        public int fishTypes;
        public LinkedList<Tuple<int, int>>[] adjacencyList;
        public int[] fish;
        public int[,] distance;
        public SynchronousShopping(int cities,int roads,int fishTypes)
        {
            this.cities = cities;
            this.roads = roads;
            this.fishTypes = fishTypes;
            fish = new int[cities+1];
            for (int i = 0; i <= cities; i++)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
            distance = new int[cities,fishTypes];
        }

        public void AddFish(int index,int[] input)
        {
            int type = 0;
            for (int i = 1; i < input[0]; i++)
                type = type | input[i];
            fish[index] = type;
        }


        public void AddEdgeAtEnd(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddLast(new Tuple<int, int>(endVertex, weight));
        }

        public void AddEdgeAtBegin(int startVertex, int endVertex, int weight)
        {
            adjacencyList[startVertex].AddFirst(new Tuple<int, int>(endVertex, weight));
        }

        public void ShortestPath()
        {
            for (int i = 1; i <= cities; i++)
                for (int j = 0; j < fishTypes; j++)
                    distance[i, j] = Int32.MaxValue;

        }


    }
}
