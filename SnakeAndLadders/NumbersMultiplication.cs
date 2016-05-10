using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class BigFactorial
    {

        public string Factorial(int n)
        {
            int[] input1, input2;
            int[] output = new int[500];
            for (int i = 2; i <= n; i++)
            {
                input1 = ConvertToArray(i);
                if (i == 2)
                    input2 = ConvertToArray(1);
                else
                {
                    input2 = output;
                }
                output = Multiply(input1, input2);
            }
            string s = ArrayToString(output);
            return s;
        }

        private string ArrayToString(int[] array)
        {
            string s = string.Empty;
            foreach (var c in array)
            {
                s = s + c.ToString();
            }
            s = new string(s.Reverse().ToArray());
            return s.TrimStart(new char[] {'0'});
        }

        private int[] Multiply(int[] input1, int[] input2)
        {
            List<List<int>> tempList = new List<List<int>>();

            for (int i = 0; i < 500; i++)
            {
                int[] temp = new int[1010];
                int carry = 0;
                for (int j = 0; j < 500; j++)
                {
                    int c = (input1[i]*input2[j]) + carry;
                    
                    if (c/10 > 0)
                    {
                        temp[j+i] = c%10;
                        carry = c/10;
                    }
                    else
                    {
                        carry = 0;
                        temp[j+i] = c;
                    }
                }
                tempList.Add(temp.ToList());
            }
            var sum = Sum(tempList);
            return sum;
        }

        private int[] Sum(List<List<int>> tempList)
        {
            int[] sum = new int[1000];

            int carry = 0;
            for (int i = 0; i < 500; i++)
            {
                int c = 0;
                for (int j = 0; j < 500; j++)
                {
                    c = c + tempList[j][i];

                }
                c = c + carry;
                if (c / 10 > 0)
                {
                    sum[i] = c % 10;
                    carry = c / 10;
                }
                else
                {
                    carry = 0;
                    sum[i] = c;
                }
            }

            return sum;
        }

        public int[] ConvertToArray(int a)
        {
            int[] input = new int[500];
            int pos = 0;
            while (a != 0)
            {
                int d = a % 10;
                input[pos] = d;
                a = a/10;
                pos++;
            }
            return input;
        }



    }
}
