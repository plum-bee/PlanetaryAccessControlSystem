using System;
using System.Windows.Forms;
using TCPConnection;

namespace PlanetAccessApp
{
    public partial class ServerListener : Form
    {
        private TCPServer _server;
        int port = 0;

        public ServerListener()
        {
            InitializeComponent();
            // Initialize the server with IP and port
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            port = int.Parse(txb_port.Text);
            _server = new TCPServer("127.0.0.1", port);
            _server.StartServer();
            lbx_Missatges.Items.Add("Server Started Correctly on " + txb_port.Text);
        }

        private void Server_ServerResponse(object sender, TCPServer.MessageEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Server_ServerResponse(sender, e)));
                return;
            }
            lbx_Missatges.Items.Add(e.Message);
        }
    }
}
