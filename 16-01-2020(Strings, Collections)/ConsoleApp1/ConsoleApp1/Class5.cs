using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class S5
    {
        public void SubString()
        {
            String sectence = "ThisSentance has five words";
            int startPosition = sectence.IndexOf(" ") + 1;
            String SecondWord = sectence.Substring(startPosition, sectence.IndexOf(" ", startPosition ) - startPosition);
            Console.WriteLine(SecondWord);
        }
    }
}
