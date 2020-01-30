using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ConsoleApp1
{
    class Demo1
    {
        public void gettingHostAddress()
        {
            IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

            Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }
    }
}
