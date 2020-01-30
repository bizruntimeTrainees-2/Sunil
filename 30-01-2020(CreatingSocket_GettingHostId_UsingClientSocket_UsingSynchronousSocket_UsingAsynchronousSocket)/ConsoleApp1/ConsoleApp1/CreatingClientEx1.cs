using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp1
{
    class CreatingClientEx1
    {
        public void StartClient()
        {
            try
            {
                //connect to remote server
                //Get Host IP Address that is used to etablish a connection
                // In this case, we got one IP address of localhost that is IP: 127.0.0.1
                //If a host has multiple addresses, you will get a list of address
                IPHostEntry iPHostEntry = Dns.GetHostEntry("localhost");
                IPAddress iPAddress = iPHostEntry.AddressList[0];
                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 11000);

                //Create aTCP/IP socket
                Socket sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                //Connect the socket to the remote endpoint. catch any exceptions
                try
                {
                    //Connect to remote EndPoint
                    sender.Connect(iPEndPoint);

                    Console.WriteLine($"Socket Connected to {sender.RemoteEndPoint.ToString()}");

                    //Encode the data String into a byte array.
                    byte[] msg = Encoding.ASCII.GetBytes("This is a test");

                    //Send the data through the socket
                    int bytesSent = sender.Send(msg);

                    byte[] bytes = new byte[1024];
                    //Recieve the response from the remote Device.
                    int bytesRec = sender.Receive(bytes);
                    Console.WriteLine($"Echoed test = {Encoding.ASCII.GetString(bytes, 0, bytesRec)}");

                    //Release the socket.
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine($"ArgumentNullException :{ ane.ToString()}");
                }
                catch (SocketException se)
                {
                    Console.WriteLine($"SocketException is: { se.ToString()}");
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Unhandled exception : {e.ToString()}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
