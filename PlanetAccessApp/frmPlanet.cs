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

namespace PlanetAccessApp
{
    public partial class frmPlanet : Form
    {
        DatabaseConnection _dbConnection;
        public frmPlanet()
        {
            InitializeComponent();
            _dbConnection = new DatabaseConnection();
        }

       
    }
}
