using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class SteadyGene
    {
        public bool validityCheck(Dictionary<char, int> dict, int limit)
        {
            if (dict['A'] <= limit && dict['C'] <= limit && dict['G'] <= limit && dict['T'] <= limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Function(int N,string str)
        {
            int maxIndex = 0;
            int out1 = 9999999;
            int count = 0;
    Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('G',0);
            dict.Add('A', 0);
            dict.Add('C', 0);
            dict.Add('T', 0);

    int limit = N / 4;
    for (int i = N - 1; i >= 0; i--){
        dict[str[i]]++;
        if(!validityCheck(dict, limit)){
            maxIndex = i + 1;
            dict[str[i]]--;
            break;
        }
    }
    for(int minIndex = -1; minIndex < N - 1 && maxIndex < N && minIndex < maxIndex; minIndex++){
        while(!validityCheck(dict, limit) && maxIndex < N)
        {
            count++;
            dict[str[maxIndex]]--;
            maxIndex++;
        }
         if(maxIndex > N || !validityCheck(dict, limit)){
            break;
        }
        int substringLength = Math.Max(0, maxIndex - minIndex - 1);
        if(substringLength < out1){
            out1 = substringLength;
        }
        dict[str[minIndex + 1]]++;
    }
            return out1;

        }
    }
}
