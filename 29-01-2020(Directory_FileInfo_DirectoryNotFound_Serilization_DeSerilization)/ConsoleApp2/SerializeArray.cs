using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class SerializeArray
    {
        public void serializeArray()
        {
            ClassToSerialize[] serialize = new ClassToSerialize[3];
            serialize[0] = new ClassToSerialize();
            serialize[0].Age = 26;
            serialize[0].Name = "bipin";
            serialize[0].CompanyName = "xyz";
            serialize[1] = new ClassToSerialize();
            serialize[1].Age = 20;
            serialize[1].Name = "ropin";
            serialize[1].CompanyName = "abc";
            serialize[2] = new ClassToSerialize();
            serialize[2].Age = 27;
            serialize[2].Name = "thupin";
            serialize[2].CompanyName = "efg";
            FileStream stream = new FileStream(@"G:\arrayText.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, serialize);
            stream.Close();
        }
    }
}
