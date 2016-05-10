using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * The owner of a banana plantation has a camel. He wants to transport his 3000 bananas to the market,
 * which is located after the desert. The distance between his banana plantation and the market is about 1000 kilometer. 
 * So he decided to take his camel to carry the bananas. The camel can carry at the maximum of 1000 bananas at a time,
 * and it eats one banana for every kilometer it travels.

What is the largest number of bananas that can be delivered to the market?
 * 
 * */
namespace SnakeAndLadders
{
    public class CamelsAndBananas
    {
        public int totalDistance = 1000;
        public int bananaPerMile = 1;
        public int max_Load = 1000;
        public int start_Load = 3000;
        public int[] M= new int[1001];

        public CamelsAndBananas()
        {
            M[0] = start_Load;
        }

        public int BananasLeft( int startCount,int distance)
        {
            var noOfTrips = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(startCount)/max_Load));
            var val = Math.Max(0, startCount - (2 * noOfTrips - 1) * distance * bananaPerMile);
            return val;
        }

        public void  getResults()
        {
            for (int i = 1; i < 1001; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (BananasLeft(M[j], i - j) > M[i])
                    {
                        M[i] = BananasLeft(M[j], i - j);
                    }
                }
            }
        }
    }
}
