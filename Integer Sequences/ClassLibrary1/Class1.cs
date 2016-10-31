using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        /// <summary>
        /// Checks if a List contains one or more elements equal to Value. Returns True for once and False otherwise.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
