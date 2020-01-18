using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class AddingAndRetrivingFromConcurrentDictionary
    {
        public void AddingAndRetriving()
        {
            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
            dictionary.TryAdd("1", "First");
            dictionary.TryAdd("2", "Second");
            dictionary.TryAdd("3", "Third");
            dictionary.TryAdd("4", "Fourth");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }
        }
    }
}
