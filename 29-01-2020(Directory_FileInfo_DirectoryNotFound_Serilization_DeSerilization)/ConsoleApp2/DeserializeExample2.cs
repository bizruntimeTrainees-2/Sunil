using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class DeserializeExample2
    {
        public void DeSerializeNow()
        {
            ClassToSerialize serialize = new ClassToSerialize();
            FileStream stream = new FileStream(@"G:\text.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            serialize = (ClassToSerialize)formatter.Deserialize(stream);

            Console.WriteLine("Name: " + serialize.Name);
            Console.WriteLine("Age: " + serialize.Age);
            Console.WriteLine("CompanyName: " + serialize.CompanyName);
            stream.Close();
        }
    }
}
