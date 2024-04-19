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
using PlanetAccessApp;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            server = new TCPServer("127.0.0.1", 6688);
            this.server.ServerResponse += new System.EventHandler(OnMessageReceived);
        }

        private TCPServer server;

        private void button1_Click(object sender, EventArgs e)
        {
            string code = PlanetUtils.GenerateValidationCode();
            MessageBox.Show(code);
        }

        public void OnMessageReceived(object sender, System.EventArgs e)
        {
            string msgContent = ((TCPServer.MessageEventArgs)e).Message;
            MessageBox.Show(msgContent);
        }
    }
}
