using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ConsoleApp2
{
    class ReceiveCallBack
    {
        public static void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                //retrive the state object and the client socket
                //from the Asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                //read data from the remote device.
                int byteRead = client.EndReceive(ar);
                if (byteRead > 0)
                {
                    //there might be more data, so store the data recieved so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, byteRead));
                    //get the rest of data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    //All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                      //  response = state.sb.ToString();
                    }
                    //signal that all bytes have been received.
                    //receiveDone.Set();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
