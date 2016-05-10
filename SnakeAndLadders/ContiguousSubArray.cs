using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;

namespace SnakeAndLadders
{
    public class ContiguousSubArray
    {
        private int testcases;
        private Dictionary<int,List<int>> input= new Dictionary<int, List<int>>();
        public void GetValues()
        {
            testcases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testcases; i++)
            {
                int length = Convert.ToInt32(Console.ReadLine());
                var testcase = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                input.Add(length,testcase);
            }

        }
    }
}
