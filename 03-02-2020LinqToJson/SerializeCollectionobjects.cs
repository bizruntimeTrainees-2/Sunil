using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class SerializeCollectionobjects
    {
        public void serializeCollectionobjects()
        {
            List<String> videoGames = new List<string>
            {
                "StarCraft",
                "Halo",
                "GTA"
            };
            string json = JsonConvert.SerializeObject(videoGames, Formatting.Indented);
            Console.WriteLine(json);
        }        
    }
}
