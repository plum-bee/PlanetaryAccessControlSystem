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
                byte[] zippedData = _client.ZipFile(txt_filePath.Text);
                _client.SendData(zippedData);
            
            }
        }

        private void btn_sendMessage_Click(object sender, EventArgs e)
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
            if (InvokeRequired)
            {
                Invoke(new Action(() => Client_ClientResponse(sender, e)));
                return;
            }
            lbx_console.Items.Add(e.Message);
        }

        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txt_filePath.Text = filePath;
            }
        }


    }
}
