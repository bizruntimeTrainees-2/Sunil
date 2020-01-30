using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp2
{
    class DeserializeExample1
    {
        public void deserialize()
        {
            FileStream stream = new FileStream(@"F:\temp.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            //Console.WriteLine("Rollno: " + s.);
            //Console.WriteLine("Name: " + s);
        }
    }
}
