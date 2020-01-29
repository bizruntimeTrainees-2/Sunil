using System;
using System.IO;

namespace ConsoleApp1
{
    class WritingAndReadingFromCDrive
    {
        public void ReadWriteMethod()
        {
            DirectoryInfo[] cDris = new DirectoryInfo(@"C:\").GetDirectories();

            using (StreamWriter sw = new StreamWriter("G:\\C#\\27-01-2020\\files_generated\\file2.txt"))
            {
                foreach (DirectoryInfo dir in cDris)
                {
                    sw.WriteLine(dir.Name);
                }

            }

            using (StreamReader sr = new StreamReader("G:\\C#\\27-01-2020\\files_generated\\file2.txt"))
            {
                String str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
            }

           
            Console.ReadLine();

            
        }
    }
}
