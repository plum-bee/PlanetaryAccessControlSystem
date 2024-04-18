using System;
using System.Windows.Forms;
using TCPConnection;

namespace PlanetAccessApp
{
    public partial class ServerListener : Form
    {
        private TCPServer _server;
        int port = 6688;

        public ServerListener()
        {
            InitializeComponent();
            // Initialize the server with IP and port
            _server = new TCPServer("127.0.0.1", port);
            this._server.ServerResponse += new System.EventHandler(OnMessageReceived);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            port = int.Parse(txb_port.Text);
            
            _server.StartServer();
            lbx_Missatges.Items.Add("Server Started Correctly on " + txb_port.Text);
        }

      
        public void OnMessageReceived(object sender, System.EventArgs e)
        {
            string msgContent = ((TCPServer.MessageEventArgs)e).Message;
            this.Invoke((MethodInvoker)delegate
            {
                lbx_Missatges.Items.Add(msgContent);
            });
        }
    }
}
