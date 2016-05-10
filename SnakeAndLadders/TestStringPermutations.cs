using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    public class TestStringPermutations
    {
        [Test]
        public void TestPermutations()
        {
            int[] item = Console.ReadLine().Split(new char[] {' '}).Select(x => Int32.Parse(x)).ToArray();
            StringPermutations obj = new StringPermutations("ABCD");
            obj.Permute(0, 3);
        }

        [Test]
        public void TestCamelsAndBananas()
        {
            CamelsAndBananas obj = new CamelsAndBananas();
            obj.getResults();
        }

        [Test]
        public void ContestTestPlayers()
        {
            int count = TechGigContest.passCount(5, 3, 2);

        }

    }
}
