using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SnakeAndLadders
{
    //https://www.hackerrank.com/contests/hourrank-9/challenges/mandragora
    public class Mandragora
    {
        public static int  counter =0;
        public BigInteger Solve(int[] array,int start,int end,int s,BigInteger p,BigInteger[] output)
        {
            counter++;
            if (start == end)
            {
                if (output[start] == 0)
                {
                    output[start] = p + s * array[start];
                }
                return output[start];
            }
            else if (output[start] == 0)
            {
                BigInteger p1 = output[start + 1] == 0 ? Solve(array, start + 1, end, s + 1, p, output) : output[start + 1];
                BigInteger p2 = s * array[start] + (output[start + 1] == 0 ? Solve(array, start + 1, end, s, p, output) : output[start + 1]);

                 p = BigInteger.Max(p1, p2);
                output[start] = p;
            }
            return output[start];

        }

        public BigInteger Solve4(int[] array, int start, int end, int s, BigInteger p, BigInteger[] output)
        {
            
            BigInteger c = 0;
            int j = 0;
             for(int i =1;i<=array.Length;i++)
            {
                j = i - 1;
                p = 0;
                while(j>=0)
                {
                    p = p+((array.Length - (i-1)) * array[array.Length - (1 + j)]);
                    j--;
                }
                c = BigInteger.Max(c, p);
            }
            return c;

        }

        public static BigInteger Solve5(int[] array, int start, int end, int s, BigInteger p, BigInteger[] output)
        {
            BigInteger sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum = sum + array[i];
            BigInteger c = 0;
            BigInteger cursum = 0;
            for (int i = 0; i <= array.Length; i++)
            {
                cursum = cursum + ((i > 0) ? array[i - 1] : 0);
                p = (i + 1) * (sum - cursum);
                c = BigInteger.Max(p, c);
            }
            return c;

        }

        public int Solve2(int[] array, int start, int end, int s, int p)
        {
            counter++;
            if (start == end)
            {
                
                return p + s * array[start];
            }
           
                int p1 = Solve2(array, start + 1, end, s + 1, p);
                int p2 = Solve2(array, start + 1, end, s, p + s * array[start]);

            p = Math.Max(p1, p2);


            return p;

        }

        public BigInteger Solve3(int[] array, int start, int end, int s, BigInteger p)
        {
            counter++;
            if (start == end)
            {

                return p + s * array[start];
            }

            BigInteger p1 = Solve3(array, start + 1, end, s + 1, p);
            BigInteger p2 = Solve3(array, start + 1, end, s, p + s * array[start]);

            /*if (p1.CompareTo(p2) > 1)
                p = p2;
            else
                p = p1;*/
            p = BigInteger.Max(p1, p2);


            return p;

        }

        public BigInteger Getmax(int[] array)
        {
            BigInteger max = 0;
            int c = 0;
            Array.Sort(array);
            BigInteger[] output = new BigInteger[array.Length];
            max = Solve3(array, 0, array.Length - 1, 1, 0);
            max = Solve5(array, 0, array.Length - 1, 1, 0,output);
            return max;
        }

        public int GetmaxInt(int[] array)
        {
            int  max = 0;
            int c = 0;
            Array.Sort(array);
            BigInteger[] output = new BigInteger[array.Length];
            max = Solve2(array, 0, array.Length - 1, 1, 0);

            return max;
        }

        public  int[] RotateRightOne(int[] input)
        {
            var last = input.Length - 1;
            for (var i = 0; i < last; i += 1)
            {
                input[i] ^= input[last];
                input[last] ^= input[i];
                input[i] ^= input[last];
            }
            return input;
        }
    }
}
