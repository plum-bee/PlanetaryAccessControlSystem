using System;
using System.Windows.Forms;
using TCPConnection;

namespace SpaceshipApp
{
    public partial class frmCodeSender : Form
    {
        private TCPCLient _client;

        public frmCodeSender()
        {
            InitializeComponent();
            _client = new TCPCLient("127.0.0.1", 6688);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!_client.IsConnected)
            {
                _client.Connect();
                MessageBox.Show("Connected to server!");
                _client.SendMessage(txtDeliveryCode.Text);

            }
        }

        private void Client_ClientResponse(object sender, TCPCLient.MessageEventArgs e)
        {
            // Ensure thread safety when accessing controls
            if (InvokeRequired)
            {
                Invoke(new Action(() => Client_ClientResponse(sender, e)));
                return;
            }
            // Update your UI here, e.g., displaying messages in a ListBox
            lbx_console.Items.Add(e.Message);
        }
    }
}
