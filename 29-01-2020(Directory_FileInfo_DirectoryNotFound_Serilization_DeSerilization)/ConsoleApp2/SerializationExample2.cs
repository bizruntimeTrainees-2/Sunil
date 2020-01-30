using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    [Serializable]
    class SerializationExample2
    {
        public void serializeNow()
        {
            ClassToSerialize c = new ClassToSerialize();
            c.Age = 26;
            c.Name = "bipin";
            c.CompanyName = "xyz";
            FileStream stream = new FileStream(@"G:\text.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, c);
            stream.Close();
        }
    }
}
