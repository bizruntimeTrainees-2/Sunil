using System;

namespace ConsoleApp6
{
    class Program
    {
        public void Show(params int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Show(2, 4, 5, 6, 7, 8, 9, 10);
        }
    }
}
