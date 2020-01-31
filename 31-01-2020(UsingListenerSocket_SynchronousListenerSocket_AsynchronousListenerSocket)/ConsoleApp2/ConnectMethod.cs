using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class ConnectMethod
    {

        public static void Connect(EndPoint remoteEP, Socket client)
        {
            client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallBackMethod.ConnectCallback), client);
           // connectDone.WaitOne();
        }
    }
}
