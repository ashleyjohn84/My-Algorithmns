using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class SnakeAndLadder
    {
        public Dictionary<int, int> JumpTable { get; set; }

        public int[] Board { get; set; }

        public int[] MaxSteps { get; set; }

        public int BoardSize { get; set; }

        public Dictionary<int,List<int>> path = new Dictionary<int, List<int>>();

        public int Output
        {
            get { return MaxSteps[BoardSize]; }
        }

        public SnakeAndLadder(int boardSize)
        {
            BoardSize = boardSize;
            Board = new int[BoardSize+1];
            MaxSteps = new int[BoardSize+1];
            for (int i = 1; i <= 6; i++)
            {
                MaxSteps[i] = 1;
                path[i] = new List<int>();
            }
            for (int i = 7; i <= BoardSize; i++)
            {
                MaxSteps[i] = 5000;
                path[i] = new List<int>();
            }
        }

        public void GetMinSteps()
        {
            for (int i = 1; i <= BoardSize; i++)
            {
                MaxSteps[i] = Math.Min(1 + GetMinimum(i), MaxSteps[i]);
               
                if (JumpTable.ContainsKey(i))
                {                    
                        MaxSteps[JumpTable[i]] = Math.Min(MaxSteps[i], MaxSteps[JumpTable[i]]);                   
                }
            }
        }

        private int GetMinimum(int i)
        {
            if (i == 1)
                return MaxSteps[i];
            int min =  MaxSteps[i-1];
            for (int j = i; j > 0 &&  j != (i-6); j--)
            {
                if (min > MaxSteps[j])
                    min = MaxSteps[j];              
            }
            return min;
        }
    }
}
