using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NotificationMethods 
    {
        public event Transformer TransformerEvents;
        public void NotifyOneCell(int x)
        {
            if(TransformerEvents != null)
            {
                TransformerEvents(x);
            }
        }
    }
    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event Recived by user1 Object");
        }
    }
    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event Recived by user2 Object");
        }
    }
}
