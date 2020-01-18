using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompleteAddingMethodAndIsCompleteProperty
    {
        public void methodAndProperty()
        {
            BlockingCollection<int> bc = new BlockingCollection<int>(boundedCapacity: 10);
            Task producerThread = Task.Factory.StartNew(() =>
            {
                for(int i = 0; i<=10; ++i)
                {
                    bc.Add(i);
                }
                bc.CompleteAdding();
            });
            Task ConsumerThread = Task.Factory.StartNew(() =>
            {
                while (!bc.IsCompleted)
                {
                    int item = bc.Take();
                    Console.WriteLine(item);
                }
            });
            Task.WaitAll(producerThread, ConsumerThread);
        }
    }
}
