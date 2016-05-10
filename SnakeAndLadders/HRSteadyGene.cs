using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class HRSteadyGene
    {
        public void Function(int cases,string s)
        {
            int requiredNum = cases/4;
            Gene input =  FindLengthofAlphabets(s);
            Gene needed = FindNeeded(input, requiredNum);
            int c = GetMinimumSubString(s,needed);
        }

        private int GetMinimumSubString(string s,Gene needed)
        {
            int count1 = 0;
            List<int> minList = new List<int>();
            int flag = 0;
            if (needed.Sum == 0)
                return 0;
            int l = 0;
            int index = 0;
            Dictionary<int,Gene> map = new Dictionary<int, Gene>();

            map[0] = new Gene(s[0]);
            if (CheckifReached(map[0], needed))
            {
                minList.Add(map[0].Sum);
            }
            else
            {

                for (int i = 1; i < s.Length; i++)
                {
                    var g = new Gene(s[i]);
                    map[i] = Add(map[i - 1], g);

                    while (CheckifReached(map[i], needed) && index <= i)
                    {
                        count1++;
                        minList.Add(map[i].Sum);
                        map[i] = Subtract(map[i], new Gene(s[index]));
                        index++;
                    }
                }
            }
            return minList.Min();
        }

        private Gene Subtract(Gene a, Gene b)
        {
            Gene c = new Gene();
            Dictionary<char, int> result = (from e in a.charLen.Concat(b.charLen)
                                            group e by e.Key into g
                                            select new { Name = g.Key, Count = (a.charLen[g.Key] - b.charLen[g.Key]) >0?a.charLen[g.Key] - b.charLen[g.Key] : 0 })
              .ToDictionary(item => item.Name, item => item.Count);
            c.charLen = result;
            return c;
        }

        private bool CheckifReached(Gene gene, Gene needed)
        {
           return gene.charLen.All(kvp => needed.charLen[kvp.Key] <= kvp.Value);
        }

       


        private Gene Add(Gene a, Gene b)
        {
            Gene c = new Gene();
            Dictionary<char, int> result = (from e in a.charLen.Concat(b.charLen)
              group e by e.Key into g
              select new { Name = g.Key, Count = g.Sum(kvp => kvp.Value) })
              .ToDictionary(item => item.Name, item => item.Count);
            c.charLen = result;
            return c;
        }

        private Gene FindNeeded(Gene input, int requiredNum)
        {
            Gene g = new Gene();
            if (input.charLen['G'] > requiredNum)
            {
                g.charLen['G'] = input.charLen['G'] - requiredNum;
            }
            if (input.charLen['A'] > requiredNum)
            {
                g.charLen['A'] = input.charLen['A'] - requiredNum;
            }
            if (input.charLen['T'] > requiredNum)
            {
                g.charLen['T'] = input.charLen['T'] - requiredNum;
            }
            if (input.charLen['C'] > requiredNum)
            {
                g.charLen['C'] = input.charLen['C'] - requiredNum;
            }
            return g;
        }

        private Dictionary<char, int> FindCount(string s,int n)
        {
            Dictionary<char,int> map = new Dictionary<char, int>();
            map.Add('G', 0);
            map.Add('A', 0);
            map.Add('C', 0);
            map.Add('T', 0);
            foreach (char c in s)
            {
                map[c] = (map[c] + 1 - n) < 0 ? 0 : map[c] + 1 - n;
            }
            return map;
        }

        private Gene FindLengthofAlphabets(string s)
        {
            Gene g = new Gene();

            foreach (char c in s)
            {
                switch (c)
                {
                    case 'G':
                        g.charLen['G']++;
                        break;
                    case 'A':
                        g.charLen['A']++;
                        break;
                    case 'C':
                        g.charLen['C']++;
                        break;
                    case 'T':
                        g.charLen['T']++;
                        break;
                   
                }
            }
            return g;
        }
    }

    public class Gene
    {
      public  Dictionary<char,int> charLen = new Dictionary<char, int>();

        public int Sum
        {
            get { return charLen.Sum(x => x.Value); }
        }

        public Gene(char c) :this()
        {

            switch (c)
            {
                case 'G':
                    charLen['G']++;
                    break;
                case 'A':
                    charLen['A']++;
                    break;
                case 'C':
                    charLen['C']++;
                    break;
                case 'T':
                    charLen['T']++;;
                    break;

            }
        }

       public Gene()
        {
            charLen.Add('G',0);
            charLen.Add('A', 0);
            charLen.Add('C', 0);
            charLen.Add('T', 0);

        }

    }
}
