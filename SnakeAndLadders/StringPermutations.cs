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
                list.Add(myString);
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
    }
}
