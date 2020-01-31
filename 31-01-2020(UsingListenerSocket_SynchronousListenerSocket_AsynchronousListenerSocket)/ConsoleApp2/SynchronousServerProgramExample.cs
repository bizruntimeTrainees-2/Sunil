using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class SynchronousServerProgramExample
    {
        // incomming data from the client
        public static String data = null;
        public void StartListening()
        {
            //Data buffer for incomming data
            byte[] bytes = new byte[1024];

            //Establish the local end point for the socket
            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress iPAddress = iPHostEntry.AddressList[0];
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

            //Creating a TCP/IP socket.
            Socket listener = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //Bind the socket to the local endPoint and listen for incoming connections
            try
            {
                listener.Bind(iPEndPoint);
                listener.Listen(100);

                //Start listening for connections
                while (true)
                {
                    Console.WriteLine("Waiting for a connection....");
                    Socket handler = listener.Accept();

                    data = null;

                    //An incoming connection need to be processed
                    while (true)
                    {
                        int byteRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, byteRec);
                        if(data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    // Show the data on the Console.
                    Console.WriteLine($"Text Received : {data}");

                    //Echo the data dack to client.
                    byte[] msg = Encoding.ASCII.GetBytes(data);

                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("\nPress Enter to Continue.....");
            Console.ReadKey();
        }
    }
}
