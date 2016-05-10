using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SnakeAndLadders
{
    [TestFixture]
    public class TestJobs
    {
        [Test]
        public void TestWeldingJobs()
        {
            WeldingJob obj = new WeldingJob();
            var input = new string[]
            {"6AM#8AM", "11AM#1PM", "7AM#3PM", "7AM#10AM", "10AM#12PM", "2PM#4PM", "1PM#4PM", "8AM#9AM"};
            var input2 = new string[] { "6AM#8AM", "11AM#1PM", "7AM#3PM", "7AM#10AM", "10AM#12PM" };
            var s = WeldingJob.jobMachine(input);
        }

        [Test]
        public void TestWeldingJobs1()
        {
            WeldingJob obj = new WeldingJob();

            var input2 = new string[] { };
            var s = WeldingJob.jobMachine(input2);
        }

        [Test]
        public void TestWeldingJobs2()
        {
            WeldingJob obj = new WeldingJob();
            var input = new string[] {"6AM#10PM", "9AM#10PM","9PM#11PM","10PM#11PM"};
            var s = WeldingJob.jobMachine(input);
        }
    }
}
