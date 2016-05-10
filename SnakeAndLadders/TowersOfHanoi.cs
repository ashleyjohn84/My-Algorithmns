using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
   public class TowersOfHanoi
    {
        public int pegs { get; set; }



        public void GetSteps(int n, string from, string to,string aux)
        {
            if (n == 1)
            {
                Console.WriteLine("Move peg {0} from {1} to {2}", n, from, to);
                return;
            }
            else
            {
                GetSteps(n-1,from,aux,to);
                Console.WriteLine("Move peg {0} from {1} to {2}", n, from, to);
                GetSteps(n-1,aux,to,from);
            }
        }
    }
}
