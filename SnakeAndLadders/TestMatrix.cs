using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class TestMatrix
    {
        [Test]
        public void Testmatrix()
        {
            CandidateCode code = new CandidateCode();
            var str =CandidateCode.operations_seq(2, new string[] {"1#1", "1#1"}, new string[] {"1#1", "1#1"});
            Assert.AreEqual(str,"yes");
        }

        [Test]
        public void Testmatrix1()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(3, new string[] { "11#3#44", "12#26#13", "21#33#21" }, new string[] { "33#44#11", "3#13#12","21#26#21" });
            Assert.AreEqual(str, "yes");
        }

        [Test]
        public void Testmatrix3()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(2, new string[] { "1#1", "2#2" }, new string[] { "1#1"});
            Assert.AreEqual(str, "invalid");
        }

        [Test]
        public void Testmatrix4()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(3, new string[] { "11#3#44", "12#26#13", "21#33#21" }, new string[] { "33#44#11", "3#13#12", "21#26#21" });
            Assert.AreEqual(str, "yes");
        }

        [Test]
        public void Testmatrix5()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(1, new string[] { "1#1", "2#2" }, new string[] { "1#1" });
            Assert.AreEqual(str, "invalid");
        }


        [Test]
        public void Testmatrix6()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(0, new string[] { "1#1", "2#2" }, new string[] { "1#1" });
            Assert.AreEqual(str, "invalid");
        }

        [Test]
        public void Testmatrix7()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(1, new string[] { "1#1", "2#2#1", }, new string[] { "1#1" });
            Assert.AreEqual(str, "invalid");
        }

        [Test]
        public void Testmatrix8()
        {
            CandidateCode code = new CandidateCode();
            var str = CandidateCode.operations_seq(1, new string[] { "1#1", "2#2#1", }, new string[] {"#" });
            Assert.AreEqual(str, "invalid");
        }

        [Test]
        public void Testmatrix9()
        {
            CandidateCode code = new CandidateCode();
            var input = new string[] {"3#9#7#12", "23#3#14#9", "71#2#6#9", "13#72#14#21"};
            var output = new string[] { "3#9#14#12", "23#3#7#9", "9#71#2#14", "6#21#13#72" };
            var str = CandidateCode.operations_seq(4, input,output);
            Assert.AreEqual(str, "yes");
        }

        [Test]
        public void Testmatrix10()
        {
            CandidateCode code = new CandidateCode();
            var input = new string[] { "3#9#7#12", "23#3#14#9", "71#2#6#9", "13#72#14#21" };
            var output = new string[] { "3#9#14#12", "23#3#7#9", "9#71#2#14", "6#21#13#72" };
            var str = CandidateCode.operations_seq(4, input, input);
            Assert.AreEqual(str, "no");
        }
    }
}
