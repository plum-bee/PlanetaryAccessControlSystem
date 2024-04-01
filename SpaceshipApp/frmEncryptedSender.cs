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
using System.Security.Cryptography;

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
                            pgbDownloadKey.Value = 100;
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

        private void btnValidationCode_Click(object sender, EventArgs e)
        {
            GetValidationKey();
        }

        private void GetValidationKey()
        {
            try
            {
                string planetName = txtPlanet.Text.Trim();

                DataSet planetsDataSet = _databaseConnection.RetrieveDataUsingQuery($"SELECT idPlanet FROM Planets WHERE DescPlanet = '{planetName}'");

                if (planetsDataSet.Tables.Count > 0 && planetsDataSet.Tables[0].Rows.Count > 0)
                {
                    int idPlanet = Convert.ToInt32(planetsDataSet.Tables[0].Rows[0]["idPlanet"]);

                    DataSet encryptionDataSet = _databaseConnection.RetrieveDataUsingQuery($"SELECT ValidationCode FROM InnerEncryption WHERE idPlanet = {idPlanet}");

                    if (encryptionDataSet.Tables.Count > 0 && encryptionDataSet.Tables[0].Rows.Count > 0)
                    {
                        string validationCode = encryptionDataSet.Tables[0].Rows[0]["ValidationCode"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.Filter = "Text files (*.txt)|*.txt"; 
                        saveFileDialog.FileName = $"{planetName}_ValidationCode.txt"; 
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllText(saveFileDialog.FileName, validationCode);
                            MessageBox.Show("Validation code saved successfully.");
                            pgbDownloadCode.Value = 100;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No validation code found for the planet '{planetName}'.");
                    }
                }
                else
                {
                    MessageBox.Show($"No planet found with the name '{planetName}'.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving validation code: {ex.Message}");
            }
        }

        private void btnSelectCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select a Validation Code File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string validationCode = File.ReadAllText(selectedFilePath);

                txtValidationCode.Text = validationCode;
            }
        }

        private void btnEncryptCode_Click(object sender, EventArgs e)
        {
            string validationCode = txtValidationCode.Text;
            string xmlPublicKey = txtPlanetKey.Text; 

            if (string.IsNullOrEmpty(validationCode) || string.IsNullOrEmpty(xmlPublicKey))
            {
                MessageBox.Show("Validation code or public key is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(xmlPublicKey);

                // Convert the validation code to bytes and encrypt
                byte[] bytesToEncrypt = Encoding.UTF8.GetBytes(validationCode);
                byte[] encryptedBytes = rsa.Encrypt(bytesToEncrypt, false); // 'false' for OAEP padding (true for PKCS#1 v1.5)

                string encryptedValidationCode = Convert.ToBase64String(encryptedBytes);

                txtEncryptedCode.Text = encryptedValidationCode;

                MessageBox.Show("Validation code encrypted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption failed: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSelectKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml"; 
            openFileDialog.Title = "Select an XML Key File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string xmlKey = File.ReadAllText(selectedFilePath);

                txtPlanetKey.Text = xmlKey;
            }
        }

    }
}
