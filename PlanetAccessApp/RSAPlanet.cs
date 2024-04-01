using System;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using DataAccessLibrary;

namespace PlanetAccessApp
{
    public partial class RSAPlanet : Form
    {
        public RSAPlanet()
        {
            InitializeComponent();
        }

        private string _keyName;
        private string _planetName;

        private void btn_generate_Click(object sender, EventArgs e)
        {
            _keyName = txtKeyContainer.Text.Trim();
            _planetName = txtPlanet.Text.Trim();

            if (string.IsNullOrWhiteSpace(_keyName) || string.IsNullOrWhiteSpace(_planetName))
            {
                MessageBox.Show("Key Name and Planet Name must not be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                GenerateAndSaveKeys(_keyName, _planetName);
                MessageBox.Show("Keys were successfully generated and saved.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerateAndSaveKeys(string keyName, string planetName)
        {
            try
            {
                CspParameters csp = new CspParameters
                {
                    KeyContainerName = keyName
                };

                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(csp))
                {
                    rsa.PersistKeyInCsp = true;

                    string publicKey = rsa.ToXmlString(false);
                    SaveKeyToDatabase(planetName, publicKey);
                }
            }
            catch (CryptographicException ce)
            {
                MessageBox.Show($"Cryptographic error occurred: {ce.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SaveKeyToDatabase(string planetName, string publicKey)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();

            try
            {
                string queryToGetPlanetId = $"SELECT idPlanet FROM Planets WHERE DescPlanet = '{planetName}'";
                DataSet planetData = dbConnection.RetrieveDataUsingQuery(queryToGetPlanetId);

                if (planetData != null && planetData.Tables[0].Rows.Count > 0)
                {
                    string planetId = planetData.Tables[0].Rows[0]["idPlanet"].ToString();

                    string insertQuery = $"INSERT INTO PlanetKeys (idPlanet, XMLKey) VALUES ('{planetId}', '{publicKey}')";
                    dbConnection.ExecuteSqlNonQuery(insertQuery);
                }
                else
                {
                    MessageBox.Show("Planet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save key to database: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
