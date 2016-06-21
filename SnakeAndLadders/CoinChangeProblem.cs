using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SnakeAndLadders
{
    public class CoinChangeProblem
    {
        public int GetCountOfSolutions(int[] input,int m,int Sum)
        {
            if (Sum == 0)
                return 1;
            if (Sum < 0)
                return 0;
            if (m <= 0 && Sum > 0)
                return 0;
            return GetCountOfSolutions(input, m - 1, Sum) + GetCountOfSolutions(input, m, Sum - input[m - 1]);
        }

        public BigInteger GetCountOfSolutions1(int[] input, int m, int Sum)
        {
            BigInteger[,] table = new BigInteger[Sum+1,m];

            for (int i = 0; i < m; i++)
                table[0,i] = 1;
            for(int i =1;i<=Sum;i++)
            {
                for(int j =0;j<m;j++)
                {
                    BigInteger x = i - input[j] >= 0 ? table[i - input[j], j] : 0;

                    BigInteger y = j >= 1 ? table[i, j - 1] : 0;

                    table[i, j] = x + y;
                }
            }
            return table[Sum, m-1];

        }


    }
}
