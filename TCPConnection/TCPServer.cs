using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace TCPConnection
{
    public class TCPServer
    {
        private readonly TcpListener _listener;
        private bool _isConnected;
        public event EventHandler ServerResponse;
        public event EventHandler<FileReceivedEventArgs> FileReceived;

        public class FileReceivedEventArgs : EventArgs
        {
            public string FilePath { get; }
            public FileReceivedEventArgs(string filePath)
            {
                FilePath = filePath;
            }
        }

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

        private void ReceiveFiles(int port)
        {
            TcpListener listener = null;
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            while (true)
            {
                if (listener.Pending())
                {
                    TcpClient client = null;
                    NetworkStream netstream = null;
                    try
                    {
                        client = listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        string saveFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FilesTCP");
                        if (!Directory.Exists(saveFolderPath))
                            Directory.CreateDirectory(saveFolderPath);
                        string saveFileName = Path.Combine(saveFolderPath, "PACS.zip"); // Nombre aleatorio para el archivo
                        FileStream fileStream = new FileStream(saveFileName, FileMode.Create);
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = netstream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);
                        }
                        fileStream.Close();
                        netstream.Close();
                        client.Close();
                        OnFileReceived(saveFileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        netstream?.Close();
                        client?.Close();
                    }
                }
            }
        }



        protected virtual void OnFileReceived(string filePath)
        {
            FileReceived?.Invoke(this, new FileReceivedEventArgs(filePath));
        }
    }
}
