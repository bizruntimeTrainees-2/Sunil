using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    public class StateObject
    {
        //Client socket
        public Socket workSocket = null;
        //size of receive buffer
        public const int BufferSize = 256;
        //receive buffer
        public byte[] buffer = new byte[BufferSize];
        //Receive data string
        public StringBuilder sb = new StringBuilder();
    }
}
