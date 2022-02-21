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
                try
                {
                    // client = Client(('108.128.24.171', 11211))
                    tcpClient.Connect("108.128.24.171", 11211);
                    Console.WriteLine("Port open");
                }
                catch (Exception)
                {
                    Console.WriteLine("Port closed");
                }
            }
        }
    }
}
