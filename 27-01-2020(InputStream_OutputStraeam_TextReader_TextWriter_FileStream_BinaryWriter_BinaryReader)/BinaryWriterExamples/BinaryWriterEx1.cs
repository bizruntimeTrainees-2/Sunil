using System;
using System.IO;

namespace BinaryWriterExamples
{
    class BinaryWriterEx1
    {
       public void binaryWriter()
        {
            string fileName = "G:\\C#\\27-01-2020\\files_generated\\file5.dat";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(205);
                writer.Write("This is a String");
                writer.Write(true);
            }
            Console.WriteLine("Data Written successfully");
        }
    }
}
