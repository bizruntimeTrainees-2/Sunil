using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ConsoleApp2
{
    class SynchronousClientProgramExample
    {
        public void StartClient()
        {
            // Data buffer for incomming data.
            byte[] bytes = new byte[1024];

            // Connect to remoteDevice
            try
            {
                //Establish the remote endpoinr fo the socket.
                IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress iPAddress = iPHostEntry.AddressList[0];
                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

                //Create a TCP/IP socket
                Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                //Connect the socket to the remote EndPoint Catch any errors.
                try
                {
                    sender.Connect(iPEndPoint);

                    Console.WriteLine($"Socket connected to {sender.RemoteEndPoint.ToString()}");

                    //Encode the data string into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes("This is a Test<EOF>");

                    //Send the data thorugh the socket
                    int bytesSend = sender.Send(msg);

                    //Recieve the response from the remote device
                    int byteRec = sender.Receive(bytes);
                    Console.WriteLine($"Echoed test = {Encoding.ASCII.GetString(bytes, 0, byteRec)}");

                    //Release The socket

                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch(ArgumentNullException ane)
                {
                    Console.WriteLine($"ArgumentNullException: {ane.ToString()}");
                }
                catch(SocketException se)
                {
                    Console.WriteLine($"SocketException: {se.ToString()}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Unexpected Exception: {ex.ToString()}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected Exception " + ex.ToString());
            }
        }
    }
}
