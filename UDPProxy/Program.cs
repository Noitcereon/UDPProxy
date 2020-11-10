using System;

namespace UDPProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy udpProxy = new Proxy();
            udpProxy.Start();
            Console.ReadLine();
        }
    }
}
