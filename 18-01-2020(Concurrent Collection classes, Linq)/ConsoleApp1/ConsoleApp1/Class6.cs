using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    class BlockingCollectionsRemovalExample
    {
        public void RemoveItems()
        {
            BlockingCollection<int> bCol = new BlockingCollection<int>(boundedCapacity: 3);
            bCol.Add(1);
            bCol.Add(2);

            int item = bCol.Take();
            Console.WriteLine(item);
        }
    }
}
