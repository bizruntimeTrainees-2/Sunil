using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DirectoryExample1 obj = new DirectoryExample1();
            String sourceDirectory = @"F:\sorceDirectory";
            String targetDirectory = @"F:\targetDirectory";

            DirectoryInfo diSource = new DirectoryInfo(sourceDirectory);
            DirectoryInfo diTarget = new DirectoryInfo(targetDirectory);

            obj.gettingDirectoryInfo(diSource, diTarget);*/

            /*DirectoryExample2 obj = new DirectoryExample2();
            obj.CreatingDirectory();*/

            /*DirectoryExample3 obj = new DirectoryExample3();
            obj.creatingSubDirectory();*/

            /*FileInfoExample1 obj = new FileInfoExample1();
            obj.creatingFile();*/

            /*FileInfoExample2 obj1 = new FileInfoExample2();
            obj1.createText();*/

            /* FileInfoExample3 obj = new FileInfoExample3();
             obj.delete();*/

            FileInfoExample4 obj = new FileInfoExample4();
            obj.appendText();           
        }
    }
}
