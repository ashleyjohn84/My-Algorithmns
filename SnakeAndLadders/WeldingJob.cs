using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadders
{
    //TODo Remove all jobs before 5 and After 11PM
    public class WeldingJob
    {
        public static List<string> jobs = new List<string>();
        public static int counter = 0;

        public static int jobMachine(string[] input1)
        {
            foreach (var duration in input1)
            {
                var times = duration.Split('#');
                int startTime, endTime;
                if (times[0].Contains("PM"))
                {
                    var s = Convert.ToInt32(times[0].Substring(0,  times[0].IndexOf("PM")));
                    if(s!= 12)
                    startTime = Convert.ToInt32(times[0].Substring(0, times[0].IndexOf("PM"))) +
                                12;
                    else
                    {
                        startTime =
                            Convert.ToInt32(times[0].Substring(0,  times[0].IndexOf("PM")));
                    }
                    
                }
                else
                {
                    startTime = Convert.ToInt32(times[0].Substring(0,  times[0].IndexOf("AM")));
                    if(startTime == 12)
                        continue;
                }
                if((startTime < 5) || (startTime > 23) )
                    continue;
                 if (times[1].Contains("PM"))
                 {
                     var t = Convert.ToInt32(times[1].Substring(0,  times[1].IndexOf("PM")));
                     if(t!=12)
                    endTime = Convert.ToInt32(times[1].Substring(0,  times[1].IndexOf("PM"))) +
                                12;
                     else
                     {
                         endTime = Convert.ToInt32(times[1].Substring(0,  times[1].IndexOf("PM")));
                     }

                }
                else
                 {
                     endTime = Convert.ToInt32(times[1].Substring(0,  times[1].IndexOf("AM")));
                     if (endTime == 12)
                         continue;
                 }
                 if ((endTime < 5) || (endTime > 23))
                     continue;
                if(endTime < startTime)
                    continue;
                var job = startTime.ToString() + "-" + endTime.ToString();
                jobs.Add(job);

            }
            return 500*Findmaximum(jobs);

        }

        public static int Findmaximum(List<string> jobs)
        {
            if (jobs.Count == 1)
                return 1;
            if (jobs.Count == 0)
                return 0;
            else
            {
                int m1 =0, m2 = 0;

                
           
                    var endTime = jobs[0].Split('-')[1];
                    var startTime = jobs[0].Split('-')[0];
                    var newJobs = RemoveJobs(jobs, 0);
                    m2 = Findmaximum(newJobs);
                    newJobs.RemoveAll(x =>

                       !((Convert.ToInt32(x.Split('-')[0]) < Convert.ToInt32(startTime) && Convert.ToInt32(x.Split('-')[1])  <= Convert.ToInt32(startTime))
                        ||
                         (Convert.ToInt32(x.Split('-')[0]) >= Convert.ToInt32(endTime) && Convert.ToInt32(x.Split('-')[1])  > Convert.ToInt32(endTime)))
                       
                        );
                    m1 = 1 + Findmaximum(newJobs);
                return Math.Max(m1, m2);

                
               
            }
        }

        public static List<string> RemoveJobs(List<string> myList , int index)
        {
            var list = new List<string>();
            for (int i = 0; i < myList.Count; i++)
            {
                if(i != index)
                list.Add(myList[i]);
            }
            return list;
        }


    }
}
