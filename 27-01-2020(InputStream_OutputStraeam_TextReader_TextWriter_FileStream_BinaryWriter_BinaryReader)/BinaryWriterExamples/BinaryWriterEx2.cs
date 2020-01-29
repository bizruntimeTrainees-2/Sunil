using System;
using System.IO;

namespace BinaryWriterExamples
{
    class BinaryWriterEx2
    {
        const String fileName = "G:\\C#\\27-01-2020\\files_generated\\file6.dat";
        public void writeDefaultValues()
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(1.250F);
                writer.Write(@"C:\TEMP");
                writer.Write(10);
                writer.Write(true);
            }
            Console.WriteLine("Data Written successfully");
        }
    }
}
