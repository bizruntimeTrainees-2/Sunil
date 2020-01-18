using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    class BlockingTryTakeExample
    {
        public void tryTakeMethod()
        {
            BlockingCollection<int> bc = new BlockingCollection<int>(boundedCapacity: 3);
            bc.Add(1);
            bc.Add(2);
            bc.Add(3);

            int item = bc.Take();
            Console.WriteLine(item);

            if(bc.TryTake(out item, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine(item);
            }
            else
            {
                Console.WriteLine("No Item Removed");
            }
        }
    }
}
