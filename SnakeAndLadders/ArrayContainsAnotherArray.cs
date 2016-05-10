using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*
 * To test if a main array contains all the elements of subarry then give the smallest window in main array
 * 
 * 
 * 
 */
namespace SnakeAndLadders
{
    class ArrayContainsAnotherArray
    {
        public Dictionary<int,List<int>> map = new Dictionary<int, List<int>>();
        public int windowLower, windowHigher;
        public int Function(int[] main, int[] sub)
        {
            List<int> subArray = sub.ToList();
            int highestindex;
            int lowestindex;
            int window = main.Length;
            for (int i = 0; i < main.Length; i++)
            {
                if(subArray.Contains(main[i]))
                    if (map.ContainsKey(main[i]))
                    {
                        map[main[i]].Add(i);
                    }
                    else
                    {
                        map[main[i]] = new List<int>() {i};
                    }
                if (AllkeysAdded(subArray))
                {
                    highestindex = i;
                    lowestindex = GetLowestindexWhichisCloser(subArray);
                    if (highestindex - lowestindex < window)
                    {
                        window = highestindex - lowestindex;
                        windowLower = lowestindex;
                        windowHigher = highestindex;
                    }
                }
            }
            return window;
        }


        public int GetLowestindexWhichisCloser(List<int> subarray )
        {
            List<int> nearbyOnes = new List<int>();
            foreach (var element in subarray)
            {
                nearbyOnes.Add(map[element].Max());
            }
            return nearbyOnes.Min();
        }

        public bool AllkeysAdded(List<int> subArray)
        {
            foreach (var element in subArray)
            {
                if(map.ContainsKey(element))
                    continue;
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
