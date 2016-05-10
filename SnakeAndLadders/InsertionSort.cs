using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    public class InsertionSort
    {
        public void CheckIfChaotic(int[] array)
        {
            int flag = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i-1 < array[i])
                {
                    var x = GetValidPlaces(array[i]);
                    if (!(x.Contains(i)))
                    {
                        flag = 1;
                        Console.WriteLine("Too chaotic");
                        break;
                    }
                }
            }
            if (flag == 0)
            {
                var c = Sort(array);
            }

        }

        private List<int> GetValidPlaces(int p)
        {
           List<int> places = new List<int>();
            places.AddRange(new int[] {p - 3, p - 2, p-1, p , p + 1});
            return places;
        }

        public int Sort(int[] array)
        {
            int placements = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int x = array[i];
                while (j >= 0 && array[j] > x)
                {
                    array[j+1] = array[j];
                    j = j - 1;
                    placements++;
                }
                array[j + 1] = x;
            }
            return placements;
        }
    }
}
