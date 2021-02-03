using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PrjModule22._1
{
    public static class UdpClient
    {
        public static IPAddress RemoteAddress; // Host for sending
        private const int RemotePort = 8001; // Port for sending
        private const int LocalPort = 8001; // Local receiving port
        public static string Username;


        public static void BroadcastMessage()
        {
            var sender = new System.Net.Sockets.UdpClient();
            var endPoint = new IPEndPoint(RemoteAddress, RemotePort);

            try
            {
                while (true)
                {
                    var message = Console.ReadLine();
                    var possibleMessage = message?.Split(' ');
                    if (possibleMessage?[0] == "Send" && possibleMessage[1]== "file")
                    {
                        var filePath = possibleMessage[2];
                        if (File.Exists(filePath))
                        {
                            SendMessage($"{Username} (File send): {File.ReadAllText(filePath)}", sender, endPoint);
                        }
                        else
                            Console.WriteLine("This file doesn't exist");
                    }
                    else
                        SendMessage($"{Username}: {message}", sender, endPoint);

                }
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
        public static void ReceiveMessage()
        {

            var receiver = new System.Net.Sockets.UdpClient();
            {
                receiver.ExclusiveAddressUse = false;

            }
            receiver.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            receiver.Client.Bind(new IPEndPoint(IPAddress.Any, LocalPort));

            var sender = new System.Net.Sockets.UdpClient();
            var endPoint = new IPEndPoint(RemoteAddress, RemotePort);
            SendMessage($"User with username {Username} and endpoint {endPoint.Address}:{endPoint.Port} entered the chat", sender,
                endPoint);

            receiver.JoinMulticastGroup(RemoteAddress, 20);
            IPEndPoint remoteIp = null;
            try
            {
                while (true)
                {
                    var data = receiver.Receive(ref remoteIp);
                    var message = Encoding.Unicode.GetString(data);
                    Console.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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