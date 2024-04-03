using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPConnection
{
    public class TCPServer
    {
        public TCPServer(string ip, int port)
        {
            this.port = port;
            ipAddress = IPAddress.Parse(ip);
            listener = new TcpListener(ipAddress, port);
        }

        public class MessageEventArgs : EventArgs
        {
            public string message;
        }

        private readonly TcpListener listener;
        private readonly IPAddress ipAddress;
        private readonly int port;
        private bool isConnected;
        public event EventHandler ServerResponse;

        public void StartServer()
        {
            listener.Start();
            isConnected = true;
            Thread listenerThread = new Thread(HandleIncomingConnections);
            listenerThread.Start();
            this.OnServerAnswer("Server started.");
        }

        private void HandleIncomingConnections()
        {
            while (isConnected)
            {
                if (listener.Pending())
                {
                    TcpClient client = listener.AcceptTcpClient();
                    NetworkStream ns = client.GetStream();

                    Thread clientThread = new Thread(() => HandleClient(client, ns));
                    clientThread.Start();
                }
            }
        }

        private void HandleClient(TcpClient client, NetworkStream ns)
        {
            byte[] buffer = new byte[1024];
            while (client.Connected)
            {
                int bytesRead = ns.Read(buffer, 0, buffer.Length);
                if (bytesRead > 0)
                {
                    string receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    this.OnServerAnswer($"Received: {receivedMessage}");
                }
            }

            ns.Close();
            client.Close();
        }

        public void SendMessage(NetworkStream ns, string message)
        {
            byte[] messageBuffer = Encoding.ASCII.GetBytes(message);
            ns.Write(messageBuffer, 0, messageBuffer.Length);
            this.OnServerAnswer("Message sent to the client.");
        }

        public void StopServer()
        {
            isConnected = false;
            listener.Stop();
            this.OnServerAnswer("Server stopped.");
        }

        protected virtual void OnServerAnswer(string message)
        {
            if (ServerResponse != null)
            {
                MessageEventArgs e = new MessageEventArgs();
                e.message = message;

                ServerResponse(this, e);
            }
        }
    }
}
