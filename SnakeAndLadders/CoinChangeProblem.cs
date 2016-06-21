using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
