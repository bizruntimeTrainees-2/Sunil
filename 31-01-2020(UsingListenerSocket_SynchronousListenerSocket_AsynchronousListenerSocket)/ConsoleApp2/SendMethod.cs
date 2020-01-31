using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class SendMethod
    {
        public static void Send(Socket client, String data)
        {
            // convert String data to byte data
            byte[] bytedata = Encoding.ASCII.GetBytes(data);

            //Begin sending the data to the remote device
            //client.BeginSend(bytedata, 0, bytedata.Length, SocketFlags.None, new AsyncCallback(SendCallBack), client);
        }
    }
}
