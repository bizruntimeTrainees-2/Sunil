using System;
using System.IO;

namespace BinaryWriterExamples
{
    class BinaryReaderEx1
    {
        public void WriteBinaryReader()
        {
            using (BinaryWriter bw = new BinaryWriter(File.Open("G:\\C#\\27-01-2020\\files_generated\\file7.dat", FileMode.Create)))
            {
                bw.Write(12.5);
                bw.Write("This is String data");
                bw.Write(true);
            }
        }
        public void ReadBinaryFile()
        {
            using(BinaryReader br = new BinaryReader(File.Open("G:\\C#\\27-01-2020\\files_generated\\file6.dat", FileMode.Open)))
            {
                Console.WriteLine("Double value:" + br.ReadDouble());
                Console.WriteLine("String Value: " + br.ReadString());
                Console.WriteLine("Boolean Value: " + br.ReadBoolean());
            }
        }
    }
}
