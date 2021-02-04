using System;
using System.Net;
using System.Threading.Tasks;

namespace PrjModule22._1
{
    internal static class Program
    {
        private static void Main()
        {
            try
            {
                Console.Write("Enter your name:");
                UdpClient.Username = Console.ReadLine();
                UdpClient.RemoteAddress = IPAddress.Parse("235.5.5.11");
                Task.Run(UdpClient.ReceiveMessage);

                UdpClient.BroadcastMessage();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}