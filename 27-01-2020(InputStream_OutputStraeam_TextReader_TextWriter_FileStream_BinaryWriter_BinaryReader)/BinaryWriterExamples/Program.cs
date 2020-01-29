using System;

namespace BinaryWriterExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BinaryWriterEx1 obj = new BinaryWriterEx1();
            obj.binaryWriter();*/

            /*BinaryWriterEx2 obj = new BinaryWriterEx2();
            obj.writeDefaultValues();*/

            /*BinaryReaderEx1 obj = new BinaryReaderEx1();
            obj.WriteBinaryReader();
            obj.ReadBinaryFile();
            Console.ReadKey();*/

            BinaryReaderEx2 obj = new BinaryReaderEx2();
            obj.WriteDefaultValues();
            obj.DisplayValues();
            Console.ReadKey();

        }
    }
}
