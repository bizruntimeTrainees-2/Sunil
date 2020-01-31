using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class UsingSynchronousAcceptRequest
    {
        public static void AcceptRequest()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

            Socket listener = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(iPEndPoint);
            listener.Listen(100);

            Console.WriteLine("Waiting for the connection");
            Socket handler = listener.Accept();
            String data = null;

            while (true)
            {
                byte[] bytes = new byte[1024];
                int byteRec = handler.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                if (data.IndexOf("<EOF>") > -1)
                {
                    break;
                }
            }
            Console.WriteLine($"Text Recieved: {data}");
            byte[] msg = Encoding.ASCII.GetBytes(data);
            handler.Send(msg);
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
        }
    }
}
