using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakeAndLadders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SnakeAndLadders.Tests
{
    [TestClass()]
    public class MandragoraTests
    {
        [TestMethod()]
        public void GetmaxTest()
        {
            Mandragora obj = new Mandragora();
           // BigInteger b = obj.Getmax(new int[] { 2,6,4,9 });
           // BigInteger b1 = obj.Getmax(new int[] { 474 ,966, 379, 9942735 ,725, 603, 508, 460, 490, 66, 262, 729, 888, 864 ,159 ,956, 6068171 ,957 ,357 ,909 });
            BigInteger c= obj.Getmax(new int[]{ 1188729,1052940,9159214,1041177,1109408,1127712,708150,1358977,769261,990618 ,8711306, 656084 ,156949 ,1188775 ,9153873 ,9345902 });
            //int d = obj.GetmaxInt(new int[] { 1188729, 1052940, 9159214, 1041177, 1109408, 1127712, 708150, 1358977, 769261, 990618, 8711306, 656084, 156949, 1188775, 9153873, 9345902 });
        }
    }
}