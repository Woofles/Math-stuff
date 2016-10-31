using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathy
{
    public class Sequences
    {
        public static List<int> VanEck(int length)
        {
            List<int> output = new List<int>();
            output.Add(0);
            for (int i = 0; i < length-1; i++)
            {
                if (Properties.ContainsOne(output, output[i]))
                {
                    output.Add(0);
                }
                else
                {
                    output.Add(Properties.distToLast(output, output[i]));
                }
            }
            return output;
        }
        public static List<int> Kolakoski(int length)
        {
            List<int> output = new List<int>();
            //                           1  2  3
            output.AddRange(new int[3] { 1, 2, 2 });
            if (length > 2)
            {
                for (int i = 2; i < length; i++)
                {
                    if (i % 2 == 0) // reversed odd/even cases because we start at arr[0]
                    {
                        for (int k = 0; k < output[i]; k++)
                        {
                            output.Add(1);
                        }
                    }
                    else
                    {
                        for (int k = 0; k < output[i]; k++)
                        {
                            output.Add(2);
                        }
                    }
                }
            }
            return output.Take(length).ToList();
        }
    }

    public class Properties
    {
        public static bool ContainsOne(List<int> list, int value)
        {
            int valueCount = 0;
            foreach (int element in list)
            {
                if (element == value) { valueCount++; }
            }
            return (valueCount == 1);
        }
        public static bool ContainsOne(int[] list, int value)
        {
            int valueCount = 0;
            foreach (int element in list)
            {
                if (element == value) { valueCount++; }
            }
            return (valueCount == 1);
        }

        public static int distToLast(List<int> list, int val)
        {
            int dist = 1;
            for (int i = list.Count - 2; i >= 0; i--)
            {
                if (list[i] == val)
                {
                    break;
                }
                dist++;
            }
            return dist;
        }
        public static int distToLast(int[] list, int val)
        {
            int dist = 1;
            for (int i = list.Length - 2; i >= 0; i--)
            {
                if (list[i] == val)
                {
                    break;
                }
                dist++;
            }
            return dist;
        }
    }
}