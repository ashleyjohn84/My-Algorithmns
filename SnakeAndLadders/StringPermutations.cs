using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class StringPermutations
    {
        List<string> list = new List<string>();
        private string myString;
        char[][] obj = new char[3][];
        public StringPermutations(string s)
        {
            myString = s;
        }

        public void Permute(int start, int end)
        {
            if(start == end)
            {
                Console.WriteLine(myString);
            }
                //list.Add(myString);

            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(start, i);
                    Permute(start+1,end);
                    Swap(start, i);
                }
            }
            
        }

        public void Swap(int a, int b)
        {
            char[] strArray = myString.ToCharArray();
            char temp = strArray[a];
            strArray[a] = strArray[b];
            strArray[b] = temp;
            myString = new string(strArray);
        }
        /* 
         * you can choose a char any number of times
         * 
         */
        public static void PrintCombinations(string letters, int length, string prefix = "")
        {
            if (length == 0)
            {
                Console.WriteLine(prefix);
                return;
            }

            for (var i = 0; i < letters.Length; i++)
            {
                var newPrefix = prefix + letters[i];
                PrintCombinations(letters, length - 1, newPrefix);
            }
        }



        /*
         * 
         * This will give combinations of all length from 0 to str.Length 
         * 
         */
        public static void CombinationsNew(string str)
        {
            int a = str.Length;
            int num = 1 << a;
            List<string> s = new List<string>();
            for (int i = 0; i < num; i++)
            {
                List<char> c = new List<char>();
                for (int j = 0; j < str.Length; j++)
                {
                    int p = i & (1 << j);
                    if (p >= 1)
                    {

                        c.Add(str[j]);
                    }
                }
                if (c.Count > 0)
                {
                    s.Add(new String(c.ToArray()));
                }
                //Console.WriteLine(new String(c.ToArray()));
            }

            s.ForEach(x => Console.WriteLine(x));
        }
    }
}
