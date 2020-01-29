
using System;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class ReadAndDisplayFilesAsync
    {
        public async Task readAndDisplayFilesAsync()
        {
            String filename = "G:\\C#\\27-01-2020\\files_generated\\file2.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }
            Console.WriteLine(new String(buffer));

        }
    }
}
