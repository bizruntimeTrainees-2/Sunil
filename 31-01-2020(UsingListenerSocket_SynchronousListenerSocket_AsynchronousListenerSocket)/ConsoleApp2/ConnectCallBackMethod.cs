using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class ConnectCallBackMethod
    {
        public static void ConnectCallback(IAsyncResult ar)
        {
            try
            {
                // retrive the ssocket from the state object
                Socket client = (Socket)ar.AsyncState;

                //complete the connection
                client.EndConnect(ar);

                Console.WriteLine($"Socket connected to {client.RemoteEndPoint.ToString()}");

                //signal thi connection has been made
                //connectDone.Set();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        
    }
}
