using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SnakeAndLadder obj = new SnakeAndLadder(20);
            obj.JumpTable = new Dictionary<int, int>()
            {
                {4,8},{7,11},{12,19},{13,5}
            };
             * */
            /*
            SnakeAndLadder obj = new SnakeAndLadder(100);
            obj.JumpTable = new Dictionary<int, int>()
            {
                { 1, 38},{  4, 14},{  9, 31},{ 16,  6},{ 21, 42},{ 28, 84},{ 36, 44},{
        48, 26},{ 49, 11},{ 51, 67},{ 56, 53},{ 62, 19},{ 64, 60},{ 71, 91},{
        80,100},{ 87, 24},{ 93, 73},{ 95, 75},{ 98, 78}
            };
             * 
             * */
            SnakeAndLadder obj = new SnakeAndLadder(100);
            obj.JumpTable = new Dictionary<int, int>()
            {
                {4,8},{7,99},{12,19},{13,5}
            };
            obj.GetMinSteps();
            int y = obj.Output;
        }
    }
}
