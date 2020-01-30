using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    class Demo3
    {
        public void RecievingMsg()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

            Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                sender.Connect(iPEndPoint);

                Console.WriteLine($"Socket Connected to {sender.RemoteEndPoint.ToString()}");

                byte[] msg = System.Text.Encoding.ASCII.GetBytes("This is Test");
                int bytesSend = sender.Send(msg);

                byte[] bytes = new byte[1024];

                int bytesRec = sender.Receive(bytes);
                Console.WriteLine($"Echoed text {System.Text.Encoding.ASCII.GetString(bytes, 0, bytesRec)}");

                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
