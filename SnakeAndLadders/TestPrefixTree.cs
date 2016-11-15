using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Compatibility;

namespace SnakeAndLadders
{
    public class TestPrefixTree
    {
        [Test]
        public void TestTree()
        {
            PrefixTreeDict tree = new PrefixTreeDict();
            tree.Add("Hello");
            var task = GetWords("https://en.wikipedia.org/wiki/India");
            var list = task.Result.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in list)
            {
                tree.Add(s);
            }

            var task1 = GetWords("https://en.wikipedia.org/wiki/Pakistan");
            var list1 = task1.Result.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0;
            List<string> ncommon = new List<string>();
            foreach (var s in list1)
            {
                if (!(tree.Contains(s)))
                {
                    count++;
                    ncommon.Add(s);
                }
                  
            }
            stopwatch.Stop();
            var time = stopwatch.Elapsed;
        }

        private async Task<string> GetWords(string address)
        {
            WebClient client = new WebClient();
            var task = await client.DownloadStringTaskAsync(address);
            return task;
        }
    }
}
