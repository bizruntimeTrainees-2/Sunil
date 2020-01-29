using System;
using System.IO;

namespace TextWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TextWriter obj = new TextWriter();
                obj.textWriter();*/

            /*TextWriterEx1 obj = new TextWriterEx1();
            obj.textWriter();*/

            /* TextReader obj = new TextReader();
             obj.textReader();*/

            /*TextReaderEx1 obj = new TextReaderEx1();
            obj.textReader();*/

            TextReaderEx2 obj = new TextReaderEx2();
            obj.textReader();
        }
    }
}
