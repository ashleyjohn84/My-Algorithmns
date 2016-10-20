using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SnakeAndLadders
{

    // A variation is to find no of subsets that match to a sum. The key difference is in Coin Change i can use a number
    // multiple times.
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
            return GetCountOfSolutions(input, m - 1, Sum) + GetCountOfSolutions(input, m-1, Sum - input[m - 1]);
        }
        /* Here I could use the same number multiple times */
        public BigInteger GetCountOfSolutions1(int[] input, int m, int Sum)
        {
            BigInteger[,] table = new BigInteger[Sum+1,m];

            for (int i = 0; i < m; i++)
                table[0,i] = 1;
            for(int i =1;i<=Sum;i++)
            {
                for(int j =0;j<m;j++)
                {
                    BigInteger x = ((i - input[j] >= 0))? table[i - input[j], j] : 0;

                    BigInteger y = j >= 1 ? table[i, j - 1] : 0;

                    table[i, j] = x + y;
                }
            }
            return table[Sum, m-1];

        }

        /* Here I could use the same number only once */
        public BigInteger GetCountOfSolutions2(int[] input, int m, int Sum)
        {
            BigInteger[,] table = new BigInteger[Sum + 1, m+1];

            for (int i = 0; i <= m; i++)
                table[0, i] = 1;

            for (int i = 1; i <= Sum; i++)
                table[i, 0] = 0;

            for (int i = 1; i <= Sum; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    //BigInteger x = ((i - input[j] >= 0)) ? table[i - input[j], j] : 0;

                    BigInteger x = ((i - input[j-1] >= 0) && (j - 1 >= 0) ) ? table[i - input[j-1], j - 1] : 0;

                    BigInteger y = j >= 1 ? table[i, j - 1] : 0;

                    table[i, j] = x+y;
                }
            }
            return table[Sum, m];

        }

        /* Another variation which has memory req of only O(n) where n == SUM */

        public static int GetmNumberOfSubsets(int[] numbers, int sum)
        {
            int[] dp = new int[sum + 1];
            dp[0] = 1;
            int currentSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                currentSum += numbers[i];
                for (int j = Math.Min(sum, currentSum); j >= numbers[i]; j--)
                    dp[j] += dp[j - numbers[i]];
            }

            return dp[sum];
        }

        // A more readable variation of the above.
        public static int GetmNumberOfSubsets1(int[] numbers, int sum)
        {
            int[] dp = new int[sum + 1];
            dp[0] = 1;
            int currentSum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < sum)
                {
                    for (int j = sum - numbers[i]; j >= 0; j--)
                    {
                        if (dp[j] == 1)
                            dp[j + numbers[i]] += dp[j];
                    }
                }
            }

            return dp[sum];
        }



    }
}
