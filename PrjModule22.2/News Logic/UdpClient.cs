using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using PrjModule22._2.Misc;

namespace PrjModule22._2.News_Logic
{
    public class UdpClient
    {
        public delegate void AccountHandler(object sender, BroadcastEventArgs e);

        private const int LocalPort = 8001; // Local receiving port
        public IPAddress RemoteAddress; // Host for sending
        public event AccountHandler Broadcast;

        public void BroadcastMessage(string message)
        {
            var sender = new System.Net.Sockets.UdpClient();
            var endPoint = new IPEndPoint(RemoteAddress, LocalPort);

            try
            {
                SendMessage(message, sender, endPoint);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sender.Close();
            }
        }

        public void ReceiveMessage()
        {
            var receiver = new System.Net.Sockets.UdpClient();
            {
                receiver.ExclusiveAddressUse = false;
            }
            receiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            receiver.Client.Bind(new IPEndPoint(IPAddress.Any, LocalPort));

            receiver.JoinMulticastGroup(RemoteAddress, 20);
            IPEndPoint remoteIp = null;
            try
            {
                while (true)
                {
                    var data = receiver.Receive(ref remoteIp);
                    var message = Encoding.Unicode.GetString(data);
                    Broadcast?.Invoke(this, new BroadcastEventArgs(message));
                }
            }
            finally
            {
                receiver.Close();
            }
        }

        private static void SendMessage(string message, System.Net.Sockets.UdpClient sender, IPEndPoint endPoint)
        {
            var data = Encoding.Unicode.GetBytes(message);
            sender.Send(data, data.Length, endPoint);
        }
    }
}