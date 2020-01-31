using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class SendCallBackMethod
    { 
        public static void SendCallback(IAsyncResult ar)
        {
            try
            {
                //retrive data for the state object
                Socket client = (Socket)ar.AsyncState;

                //complete sending data to remote device
                int bytesSend = client.EndSend(ar);
                Console.WriteLine($"Bytes send to server {bytesSend}");

                //signal that all bytes sent to server
                //sendDone.Set();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
