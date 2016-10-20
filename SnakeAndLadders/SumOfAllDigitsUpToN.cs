using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{

    //http://www.geeksforgeeks.org/count-sum-of-digits-in-numbers-from-1-to-n/
    public class SumOfAllDigitsUpToN
    {
        public static int sumofDigits(int n)
        {
            if (n < 10)
                return n * (n + 1) / 2;
            int digits = Convert.ToInt32(Math.Floor(Math.Log10(Convert.ToDouble(n))));

            int[] array = new int[digits + 1];

            array[0] = 0; array[1] = 45;
            for (int i = 2; i <= digits; i++)
                array[i] = array[i - 1] * 10 + Convert.ToInt32(45 * Math.Ceiling(Math.Pow(10, i - 1)));

            int p = Convert.ToInt32(Math.Ceiling(Math.Pow(10, digits)));
            int msd = n / p;

            int y= msd*array[digits] +(msd * (msd - 1) / 2) * p + 
                msd * (1 + (n % p)) + sumofDigits(n % p);
            return y;
        }
    }
}
