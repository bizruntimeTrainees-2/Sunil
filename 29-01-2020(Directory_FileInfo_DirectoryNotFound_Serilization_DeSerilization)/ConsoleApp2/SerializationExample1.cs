using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace ConsoleApp2
{
    [Serializable]
    class SerializationExample1
    {
        public void SerilizeNow()
        {
            Student student = new Student(101, "sono");
          
            FileStream fs = new FileStream(@"F:\temp.dat", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, student);
            fs.Close();
        }
    }
}
