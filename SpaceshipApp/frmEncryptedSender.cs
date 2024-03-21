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
                string planetName = txtPlanet.Text.Trim(); 

                DataSet planetsDataSet = _databaseConnection.RetrieveDataUsingQuery($"SELECT idPlanet FROM Planets WHERE DescPlanet = '{planetName}'");

                if (planetsDataSet.Tables.Count > 0 && planetsDataSet.Tables[0].Rows.Count > 0)
                {
                    int idPlanet = Convert.ToInt32(planetsDataSet.Tables[0].Rows[0]["idPlanet"]);

                    DataSet keysDataSet = _databaseConnection.RetrieveDataUsingQuery($"SELECT * FROM PlanetKeys WHERE idPlanet = {idPlanet}");

                    if (keysDataSet.Tables.Count > 0 && keysDataSet.Tables[0].Rows.Count > 0)
                    {
                        string xmlPublicKey = keysDataSet.Tables[0].Rows[0]["XMLKey"].ToString(); 

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "XML files (*.xml)|*.xml";
                        saveFileDialog.FileName = $"{planetName}_public_key.xml"; 
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog.FileName, xmlPublicKey);
                            MessageBox.Show("XML public key downloaded successfully.");
                            pgbDownload.Value = 100;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No XML public key found for the planet '{planetName}'.");
                    }
                }
                else
                {
                    MessageBox.Show($"No planet found with the name '{planetName}'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading XML public key: {ex.Message}");
            }
        }
    }
}
