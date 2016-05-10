using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class GeneSteady
    {
        static int[] co;
       
        public int Function(int n, string s)
        {

            int count = 0;
            co = new int[256];

            int i;
            for (i = 0; i < n; i++)
            {
                co[s[i]]++;
            }

            if (Valid(n))
            {

                return 0;
            }
            int min = n;
            int st = 0;

            for (i = 0; i < n; i++)
            {
                co[s[i]]--;
                while (Valid(n) && st <= i)
                {
                    count++;
                    min = Math.Min(min, i - st + 1);
                    co[s[st]]++;
                    st++;
                }
            }

            return min;
        }
        static bool Valid(int n)
        {
            if (co['A'] <= n / 4 && co['C'] <= n / 4 && co['T'] <= n / 4 && co['G'] <= n / 4)
                return true;
            return false;
        }
    }
}
