using System;
using System.Collections.Generic;
using System.Collections.Concurrent;

namespace ConsoleApp1
{
    class BlockCollectionExample
    {
        public void blockCollectionMethod()
        {
            BlockingCollection<int> bc = new BlockingCollection<int>(3);
            bc.Add(1);
            bc.Add(2);
            if(bc.TryAdd(3, TimeSpan.FromSeconds(1)))
            {
                Console.WriteLine("ItemAdded");
            }
            else
            {
                Console.WriteLine("ItemNotAdded");
            }

            for(int i = 0; i <= 3; i++)
            {

            }

            foreach(int i in bc)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
