using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadLocking
{
    class ThreadPrioritesClass
    {
        public static long count1, count2;
        public static void IncrementCount1()
        {
            while (true)
                count1 += 1;
        }
        public static void IncrementCount2()
        {
            while (true)
                count2 += 1;
        }
    }
}
