using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    class Demo2
    {
        public void SendingMsg()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

            Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(iPEndPoint);

                Console.WriteLine($"Socket connected tp {sender.RemoteEndPoint.ToString()}");

                byte[] msg = System.Text.Encoding.ASCII.GetBytes("This is Test");

                int bytesSend = sender.Send(msg);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
