using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanEckSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(new int[0]);
            list.Add(0);
            
            for (int i = 0; i < 320; i++)
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
            foreach (int num in list) { Console.Write(num + " "); }
            Console.WriteLine();
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
        
        static bool ContainsOne(List<int> list, int value)
        {
            int valueCount = 0;
            foreach (int element in list)
            {
                if (element == value) { valueCount++; }
            }
            return (valueCount == 1);
        }
    }
}
