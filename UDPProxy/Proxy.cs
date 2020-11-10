using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ModelLib;

namespace UDPProxy
{
    public class Proxy
    {
        private const string RestURI = "http://localhost:54461/api/data";
        public async void Start()
        {
            UdpClient proxyClient = new UdpClient(10100);

            while (true)
            {
                IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);
                var buffer = proxyClient.Receive(ref remoteEndPoint);
                string receivedString = Encoding.UTF8.GetString(buffer);
                Console.WriteLine(receivedString);

                SensorData sd = JsonSerializer.Deserialize<SensorData>(receivedString);
                Console.WriteLine(await PostToRestAsync(JsonSerializer.Serialize(sd)));

                Thread.Sleep(5000);
            }
        }

        private async Task<string> PostToRestAsync(string json)
        {
            using HttpClient client = new HttpClient();
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(RestURI, content);
            if (response.IsSuccessStatusCode)
            {
                return $"Added SensorData to REST Api";
            }
            return "Something went wrong during Post to Rest.";
        }
    }
}
