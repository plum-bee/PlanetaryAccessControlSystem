using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanetAccessApp
{
    public partial class RSAPlanet : Form
    {
        public RSAPlanet()
        {
            InitializeComponent();
        }


        private string _keyName;
        private string _xmlPath;

        private void btn_generate_Click(object sender, EventArgs e)
        {
            _keyName = txtKeyContainer.Text;

            if (!string.IsNullOrWhiteSpace(_keyName) && !string.IsNullOrWhiteSpace(_xmlPath))
            {
                GenerateAndSaveKeys(_keyName, _xmlPath);
            }
        }

        public void GenerateAndSaveKeys(string keyName, string folderPath)
        {
            CspParameters csp = new CspParameters
            {
                KeyContainerName = keyName
            };

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp))
            {
                rsa.PersistKeyInCsp = true;

                string publicKeyPath = Path.Combine(folderPath, "PublicKey.xml");
                string publicKey = rsa.ToXmlString(false);

                File.WriteAllText(publicKeyPath, publicKey);

                MessageBox.Show($"Keys were successfully generated and saved.\nPublic key path: {publicKeyPath}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_routeXML_Click(object sender, EventArgs e)
        {
            _xmlPath = ChooseFolderPath();
            txtRouteXML.Text = _xmlPath;
        }

        private static string ChooseFolderPath()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    return fbd.SelectedPath;
                }

                return null;
            }
        }
    }
}
