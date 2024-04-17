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
        private readonly TcpListener _listener;
        private bool _isConnected;
        public event EventHandler ServerResponse;

        public TCPServer(string ip, int port)
        {
            _listener = new TcpListener(IPAddress.Parse(ip), port);
        }

        public class MessageEventArgs : EventArgs
        {
            public string Message { get; set; }
            public byte[] Bytes { get; set; }
        }   

        public void StartServer()
        {
            _listener.Start();
            _isConnected = true;

            Thread listenerThread = new Thread(HandleIncomingConnections);
            listenerThread.Start();

            this.OnServerAnswer("Server started.");
        }

        private void HandleIncomingConnections()
        {
            while (_isConnected)
            {
                if (_listener.Pending())
                {
                    TcpClient client = _listener.AcceptTcpClient();
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
            _isConnected = false;
            _listener.Stop();

            this.OnServerAnswer("Server stopped.");
        }

        protected virtual void OnServerAnswer(string message, byte[] bytes = null)
        {
            if (ServerResponse != null)
            {
                MessageEventArgs e = new MessageEventArgs
                {
                    Message = message,
                    Bytes = bytes
                };

                ServerResponse(this, e);
            }
        }
    }
}
