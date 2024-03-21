using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary;

namespace SpaceshipApp
{
    public partial class frmEncryptedSender : Form
    {
        private DatabaseConnection _databaseConnection;
        public frmEncryptedSender()
        {
            InitializeComponent();
            _databaseConnection = new DatabaseConnection();
        }

        private void btnDownloadKeyFile_Click(object sender, EventArgs e)
        {
            GetKey();
        }

        private void GetKey()
        {
            try
            {
                DataSet dataSet = _databaseConnection.RetrieveAllDataFromTable("PlanetKeys");

                if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                {
                    string xmlPublicKey = dataSet.Tables[0].Rows[0]["XMLKey"].ToString();

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, xmlPublicKey);
                        MessageBox.Show("XML public key downloaded successfully.");
                    }
                }
                else
                {
                    MessageBox.Show("No XML public key found in the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading XML public key: {ex.Message}");
            }
        }
    }
}
