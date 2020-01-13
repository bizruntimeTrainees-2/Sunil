using System;

namespace ConsoleApp9
{
    public class Test
    {
        public int s_no;
        public String movieName;
        public String language;
        public Test(int num, String name, String lang)
        {
            this.s_no = num;
            this.movieName = name;
            this.language = lang;
        }
        public void display()
        {
            Console.WriteLine(s_no + " " + movieName + " " + language);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(1, "abcd", "telugu");
            Test t2 = new Test(2, "cdef", "hindi");
            t1.display();
            t2.display();
        }
    }
}
