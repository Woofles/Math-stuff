using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolakoski_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[0]);
            list.Add(0);

            DateTime start = new DateTime();
            DateTime end = new DateTime();

            start = DateTime.Now;
            for (int i = 0; i < 80000; i++)
            {
                if (ContainsOne(list, list[i]))
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(distToLast(list, list[i]));
                }
            }
            end = DateTime.Now;
            TimeSpan elapsed = new TimeSpan(end.Ticks - start.Ticks);
            //foreach (int num in list) { Console.Write(num + " "); }
            //Console.WriteLine();
            Console.WriteLine(elapsed.TotalSeconds);
        }
        static int distToLast(List<int> list, int val)
        {
            int dist = 1;
            for (int i = list.Count - 2; i>=0; i--)
            {
                if (list[i] == val)
                {
                    break;
                }
                dist++;
            }
            return dist;
        }

        static bool ContainsOne(List<int> list, int val)
        {
            int times = 0;
            foreach (int i in list)
            {
                if (i == val) { times++; }
            }
            return (times==1);
        }
    }
}
