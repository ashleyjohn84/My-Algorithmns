using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    class TestBigFactorials
    {
        [Test]
        public void CheckFactorial()
        {
            BigFactorial obj = new BigFactorial();
            obj.Factorial(1);
        }

        [Test]
        public void CheckInsertionSorting()
        {
            InsertionSort obj = new InsertionSort();
            obj.CheckIfChaotic(new int[] { 1,2,5,3,7,8,6,4});
        }

    }
}
