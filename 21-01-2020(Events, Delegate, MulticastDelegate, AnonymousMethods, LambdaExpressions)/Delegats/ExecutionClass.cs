using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class ExecutionClass
    {
        public void ExecutableMethods()
        {
            /*Example1 ex = new Example1();
           ex.AddNums(100, 50);
           String str = ex.SayHello("raju");
           Console.WriteLine(str);*/

            /* Example2 ex = new Example2();
             addDelegate ad = new addDelegate(ex.AddNums);
             ad.Invoke(100, 50);

             sayDelegate s = new sayDelegate(ex.SayHello);
             String str = s.Invoke("RAJU");
             Console.WriteLine(str);*/

            /* Rectangle rect = new Rectangle();
             rect.GetArea(12.34, 56.78);
             rect.GetPerimeter(12.34, 56.78);*/
            /*Rectangle rect = new Rectangle();
            RectDelegate obj = rect.GetArea;
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);
            Console.WriteLine("--------------------------------------");
            obj.Invoke(47.87, 34.89);*/

            AnonymousMethods am = new AnonymousMethods();
            GreetingsDelegate obj = delegate (String name)
            {
                return "Hello " + name + " A very good morning";
            };
            string str = obj.Invoke("Scoot");
            Console.WriteLine(str);
            
        }
    }
}
