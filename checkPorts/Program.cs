namespace checkPorts
{
    using System;
    using System.Net.Sockets;

    internal class Program
    {
        static void Main(string[] args)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                var host = "108.128.24.171";
                var port = 11211;

                try
                {
                    tcpClient.Connect(host, port);
                    Console.WriteLine($"Port {port } OPEN on {host}");
                }
                catch (Exception)
                {
                    Console.WriteLine($"Port {port} CLOSED on {host}");
                }
            }
        }
    }
}
