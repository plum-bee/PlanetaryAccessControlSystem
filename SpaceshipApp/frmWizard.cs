using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceshipApp
{
    public partial class frmWizard : Form
    {
        private Form[] steps;
        private int currentStep = 0;

        public frmWizard()
        {
            InitializeComponent();

            steps = new Form[] { new frmEncryptedSender(), new frmCodeSender() };
            ShowStep(currentStep);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep < steps.Length - 1)
            {
                currentStep++;
                ShowStep(currentStep);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                ShowStep(currentStep);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowStep(int step)
        {
            Form form = steps[step];
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            this.panelContainer.Controls.Clear();
            this.panelContainer.Controls.Add(form);
            form.Show();
        }
    }
}
