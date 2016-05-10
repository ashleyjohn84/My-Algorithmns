using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class SteadyGeneModified
    {


        public int Function(int cases, string s)
        {
            int requiredNum = cases / 4;
            var map = FindCount(s, requiredNum);
            if (isValid(map, requiredNum))
                return 0;
             return GetMinimunSubString(map, s, requiredNum);

        }

        private int GetMinimunSubString(Dictionary<char, int> map, string s,int num)
        {
            int st = 0;
            int min = 9999999;
            for (int i = 0; i < s.Length; i++)
            {
                map[s[i]]--;
                while (isValid(map,num) && st <= i)
                {
                    min = Math.Min(min, i - st + 1);
                    map[s[st]]++;
                    st++;
                }
            }
            return min;
        }

        private bool isValid(Dictionary<char, int> map,int num)
        {
            return (map['G'] <= num && map['A'] <= num && map['T'] <= num && map['C'] <= num);
        }

        private Dictionary<char, int> FindCount(string s, int n)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('G', 0);
            map.Add('A', 0);
            map.Add('C', 0);
            map.Add('T', 0);
            foreach (char c in s)
            {
                map[c] = (map[c] + 1);
            }
            return map;
        }
    }
}
