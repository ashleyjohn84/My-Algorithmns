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
            
            StringPermutations obj = new StringPermutations("ABC");
            obj.Permute(0, 2);
        }


        [Test]
        public void TestPermutationsNew()
        {

            StringPermutations.CombinationsNew("ABC");
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
