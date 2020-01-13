using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[4] { 11, 12, 13, 14 };
            arr[1] = new int[6] { 11, 12, 13, 14, 15, 16 };

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+ " ");
                }
                Console.WriteLine();
            }
        }
           
    }
}
