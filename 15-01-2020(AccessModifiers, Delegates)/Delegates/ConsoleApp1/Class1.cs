using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TestDelegate
    {
        public static int AddNum(int num, int p)
        {
            num += p;
            return num;
        }
        public static int MultNum(int num,int q)
        {
            num *= q;
            return num;
        }
    }
}
