using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HttpDemo
{
    public class Program
    {
        public static Dictionary<string, int> SessionStorage = new Dictionary<string, int>();

        public static async Task Main(string[] args)
        {
            const string NewLine = "\r\n";

            TcpListener tcpListener = new TcpListener(IPAddress.Loopback, 12345);
            tcpListener.Start();

            while (true)
            {
                var client = tcpListener.AcceptTcpClient();
                using (var stream = client.GetStream())
                {
                    byte[] buffer = new byte[100000];
                    var length = stream.Read(buffer, 0, buffer.Length);

                    string requestString = Encoding.UTF8.GetString(buffer, 0, length);
                    Console.WriteLine(requestString);

                    var sid = Guid.NewGuid().ToString();
                    var match = Regex.Match(requestString, @"sid=[^\n]*\n");
                    if (match.Success)
                    {
                        sid = match.Value.Substring(4);
                    }

                    Console.WriteLine(sid);

                    if (!SessionStorage.ContainsKey(sid))
                    {
                        SessionStorage.Add(sid, 0);
                    }

                    SessionStorage[sid]++;

                    string html = $"<h1>Hello from My Server - {DateTime.Now}</h1>" +
                                  $"<h3>You visit this website for {SessionStorage[sid]} time!</h3>";

                    string response = "HTTP/1.1 200 OK" + NewLine +
                        "Server: SimpleDemoServer 2021" + NewLine +
                        "Content-Type: text/html; charset=utf-8" + NewLine +
                        $"Set-Cookie: sid={sid.TrimEnd()}" + NewLine +
                        "Content-Length: " + html.Length + NewLine +
                        NewLine +
                        html +
                        NewLine;

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes);
                }

                Console.WriteLine(new string('=', 70));
            }
        }

    }
}
