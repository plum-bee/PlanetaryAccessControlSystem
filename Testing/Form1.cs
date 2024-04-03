using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPConnection;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.server.ServerResponse += new System.EventHandler(OnMessageReceived);
        }

        private TCPServer server = new TCPServer("127.0.0.1", 6688);

        private void button1_Click(object sender, EventArgs e)
        {
            server.StartServer();
        }

        public void OnMessageReceived(object sender, System.EventArgs e)
        {
            string msgContent = ((TCPServer.MessageEventArgs)e).message;
            MessageBox.Show(msgContent);
        }
    }
}
