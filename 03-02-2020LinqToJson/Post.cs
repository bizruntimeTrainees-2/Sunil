using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public IList<string> Categories { get; set; }
    }
}
