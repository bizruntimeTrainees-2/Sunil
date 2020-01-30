using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class DeserializeArray
    {
        public void deserializeArray()
        {
            ClassToSerialize[] serializes;
            FileStream stream = new FileStream(@"G:\arrayText.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            serializes = (ClassToSerialize[])formatter.Deserialize(stream);
            Console.WriteLine("Name :" + serializes[0].Name);
            Console.WriteLine("Age :" + serializes[0].Age);
            Console.WriteLine("Company Name :" + serializes[0].CompanyName);
            Console.WriteLine("Name :" + serializes[1].Name);
            Console.WriteLine("Age :" + serializes[1].Age);
            Console.WriteLine("Company Name :" + serializes[1].CompanyName);
            Console.WriteLine("Name :" + serializes[2].Name);
            Console.WriteLine("Age :" + serializes[2].Age);
            Console.WriteLine("Company Name :" + serializes[2].CompanyName);
            stream.Close();
        }
    }
}