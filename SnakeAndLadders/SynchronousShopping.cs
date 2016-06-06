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
        public Queue<Tuple<int,Tuple<int,int>>> queue;
        public SynchronousShopping(int cities,int roads,int fishTypes)
        {
            this.cities = cities;
            this.roads = roads;
            this.fishTypes = fishTypes;
            fish = new int[cities+1];
            adjacencyList = new LinkedList<Tuple<int, int>>[cities + 1];
            for (int i = 0; i <= cities; i++)
            {
                adjacencyList[i] = new LinkedList<Tuple<int, int>>();
            }
            distance = new int[cities+1,(1 << fishTypes)];
            queue = new Queue<Tuple<int, Tuple<int, int>>>();
        }

        public void AddFish(int index,int[] input)
        {
            int type = 0;
            for (int i = 1; i <= input[0]; i++)
                type = type | (1 << (input[i]-1));
            fish[index] = type;
        }


        //Make sure to call bidirection
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
                for (int j = 0; j < (1 << fishTypes); j++)
                    distance[i, j] = Int32.MaxValue;
            Push(1, fish[1], 0);
            while(queue.Count > 0)
            {
                var x = queue.Dequeue();

            //TODO - Get Vertex with min weight first;
                foreach(var list in adjacencyList[x.Item2.Item1]) //x.Item2.Item1 - gives you the city
                {
                    Push(list.Item1, fish[list.Item1] | x.Item2.Item2, distance[x.Item2.Item1, x.Item2.Item2] + list.Item2);
                }
                    
            }
            int ret = Int32.MaxValue;
            for(int i =0;i<(1 << fishTypes);i++)
            {
                for(int j=i;j<(1 << fishTypes);j++)
                {
                    if((i | j) == (1 << fishTypes) -1)
                    {
                        ret = Math.Min(ret, Math.Max(distance[cities, i], distance[cities, j]));
                    }
                }
            }

        }

        public void Push(int city,int fishTypes,int time)
        {
            if (distance[city, fishTypes] <= time)
                return;
            distance[city, fishTypes] = time;
            queue.Enqueue(new Tuple<int, Tuple<int, int>>(time, new Tuple<int, int>(city, fishTypes)));

        }
    }
}
