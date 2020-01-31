using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ConsoleApp2
{
    class ReceiveMethod
    {
        public static void Receive(Socket client)
        {
            try
            {
                //create the state object
                StateObject state = new StateObject();
                state.workSocket = client;

                //Begin recieve data from the remote device
                client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallBack.ReceiveCallback), state);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
