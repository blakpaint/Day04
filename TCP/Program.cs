using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse("125.253.118.38"), 81);
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.SendTimeout = 1000;
            client.ReceiveTimeout = 1000;

            try
            {
                client.Connect(ipep);
                Console.WriteLine(ipep.ToString() + "is opened.");
                client.Close();
            }
            catch
            {
                Console.WriteLine(ipep.ToString() + "is closed.");
            }
        }
    }
}
