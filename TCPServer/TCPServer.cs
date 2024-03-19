using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPServer
{
    public class TCPServer
    {
        private TcpListener listener;
        private Thread listenerThread;
        private bool isRunning;

        public int Port { get; private set; }

        public TCPServer(int port)
        {
            Port = port;
        }

        public void StartServer()
        {
            listener = new TcpListener(IPAddress.Any, Port);
            listener.Start();
            isRunning = true;

            listenerThread = new Thread(() =>
            {
                try
                {
                    while (isRunning)
                    {
                        if (listener.Pending())
                        {
                            TcpClient client = listener.AcceptTcpClient();
                            HandleClientConnection(client);
                        }
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    if (listener != null)
                    {
                        listener.Stop();
                    }
                }
            });

            listenerThread.Start();
        }

        private void HandleClientConnection(TcpClient client)
        {
            try
            {
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[1024];
                    while (client.Connected)
                    {
                        int bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0) break;

                        string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    }
                }
            }
            finally
            {
                client.Close();
            }
        }

        public void StopServer()
        {
            if (isRunning)
            {
                isRunning = false;
                listener?.Stop();
                if (listenerThread != null && listenerThread.IsAlive)
                {
                    listenerThread.Join();
                }
            }
        }
    }
}
