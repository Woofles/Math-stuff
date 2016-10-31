using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathy;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = Sequences.Kolakoski(500).ToArray();
            foreach (int num in list) { Console.Write(num + " "); }
            Console.WriteLine();
        }
    }
}
