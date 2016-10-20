using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class KillGrave
    {
        public static int[,] roads;
        public static int[] money;
        public static int N; // vertices
        public static int M;//roads;
       public static void Start()
        {
            int brans = 0;
            int brways = 0;
            for (int mask = 0; mask < (1 << N); mask++)
            {
                bool ok = true;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if ((((1 << i) & mask) != 0) && (((1 << j) & mask) != 0) && (roads[i, j] == 1))
                            ok = false;
                    }
                }
                if (ok == false)
                    continue;
                int cost = 0;

                for(int i =0;i<N;i++)
                {
                    if (((1 << i) & mask) != 0)
                    {
                        cost += money[i];
                    }
                }
                if (brans < cost)
                {
                    brans = cost;
                    brways = 0;
                }
                if (brans == cost)
                {
                    brways++;
                }
            }
        }
    }
}
