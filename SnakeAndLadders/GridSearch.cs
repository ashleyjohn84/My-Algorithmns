using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class Solution
    {

        static void Main1(String[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());
            var output = new List<string>();
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_R = Console.ReadLine().Split(' ');
                int R = Convert.ToInt32(tokens_R[0]);
                int C = Convert.ToInt32(tokens_R[1]);
                int[,] G = new int[R, C];
                for (int G_i = 0; G_i < R; G_i++)
                {
                    var input = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x)).ToList();
                    for (int j = 0; j < C; j++)
                    {
                        G[G_i, j] = input[j];
                    }
                }
                string[] tokens_r = Console.ReadLine().Split(' ');
                int r = Convert.ToInt32(tokens_r[0]);
                int c = Convert.ToInt32(tokens_r[1]);
                int[,] P = new int[r, c];
                for (int P_i = 0; P_i < r; P_i++)
                {
                    var input = Console.ReadLine().ToCharArray().Select(x => Convert.ToInt32(x)).ToList();
                    for (int j = 0; j < c; j++)
                    {
                        P[P_i, j] = input[j];
                    }
                }
                int flag = 0;
                for (int i = 0; i < R; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        int k = 0, l = 0;
                        if (P[k, l] == G[i, j])
                        {
                            flag = 1;
                            for (k = 0; k < r; k++)
                            {
                                for (l = 0; l < c; l++)
                                {
                                    if (i + k >= R || j + l >= C)
                                    {
                                        flag = 0;
                                        break;
                                    }
                                    if (P[k, l] != G[i + k, j + l])
                                    {
                                        flag = 0; break;
                                    }
                                    if (flag == 0)
                                        break;
                                }
                            }
                            if (flag == 1)
                            {
                                output.Add("YES");
                                break;
                            }
                        }
                    }
                    if (flag == 1)
                    {
                        break;
                    }

                }

                if (flag == 0)
                    output.Add("NO");
            }
            foreach (string s in output)
                Console.WriteLine(s);
        }
    }

}
