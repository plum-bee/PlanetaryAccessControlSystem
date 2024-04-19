using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace TCPConnection
{
    public class TCPCLient
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private Thread _networkThread;

        private string _ipAddress;
        private int _serverPort;
        private bool _isConnected;

        public event EventHandler ClientResponse;

        public class MessageEventArgs : EventArgs
        {
            public string Message { get; set; }
            public byte[] Bytes { get; set; }
        }

        public string IpAddress
        {
            get => _ipAddress;
            set => _ipAddress = value;
        }

        public int ServerPort
        {
            get => _serverPort;
            set => _serverPort = value;
        }

        public bool IsConnected 
        {
            get { return _client != null && _client.Connected; }
        }

        public TCPCLient(string ipAddress, int serverPort)
        {
            _ipAddress = ipAddress;
            _serverPort = serverPort;
            _client = new TcpClient();
        }

        
        public void Connect()
        {
            if (!_client.Connected)
            {
                _client.Connect(_ipAddress, _serverPort);
                _stream = _client.GetStream();
            }
            else
            {
                _isConnected = true;
                _networkThread = new Thread(ListenForMessages);
                _networkThread.Start();
            }
        }

        private void ListenForMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while (_isConnected && (bytesRead = _stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                var receivedMessage = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                this.OnClientAnswer(receivedMessage);
            }

            Disconnect();
        }

        public void SendMessage(string message)
        {
            if (_client.Connected)
            {
                byte[] data = Encoding.ASCII.GetBytes(message);
                _stream.Write(data, 0, data.Length);
            }
        }

        public void SendData(byte[] data)
        {
            if (_client.Connected)
            {
                _stream.Write(data, 0, data.Length);
            }
        }


        public void Disconnect()
        {
            if (_isConnected)
            {
                _isConnected = false;
                _stream?.Close();
                _client?.Close();
                _networkThread?.Abort();
            }
        }

        protected virtual void OnClientAnswer(string message, byte[] bytes = null)
        {
            if (ClientResponse != null)
            {
                MessageEventArgs e = new MessageEventArgs
                {
                    Message = message,
                    Bytes = bytes
                };

                ClientResponse(this, e);
            }
        }

        public byte[] ZipFile(string filePath)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    var fileToSend = archive.CreateEntry(Path.GetFileName(filePath), CompressionLevel.Optimal);

                    using (var entryStream = fileToSend.Open())
                    using (var fileStream = File.OpenRead(filePath))
                    {
                        fileStream.CopyTo(entryStream);
                    }
                }
                return memoryStream.ToArray();
            }
        }

    }
}

