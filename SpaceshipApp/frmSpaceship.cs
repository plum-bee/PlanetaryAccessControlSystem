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
using DataAccessLibrary;

namespace SpaceshipApp
{
    public partial class frmSpaceship : Form
    {
        DatabaseConnection _dbConnection;

        public frmSpaceship()
        {
            InitializeComponent();
            LoadPlanetList();
        }

        private void LoadPlanetList()
        {
            try
            {
                DataSet dataSet = _dbConnection.RetrieveAllDataFromTable("Planets");
                cmbPlanets.DisplayMember = "DescPlanet"; 
                cmbPlanets.ValueMember = "idPlanet";
                cmbPlanets.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load planets data into ComboBox: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }
    }
}
