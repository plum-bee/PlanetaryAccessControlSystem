using System;
using System.Windows.Forms;

namespace SpaceshipApp
{
    public partial class frmCodeSender : Form
    {
        private int currentStep = 1;
        private Form[] wizardSteps;

        public frmCodeSender()
        {
            InitializeComponent();
            InitializeWizardSteps();
            ShowCurrentStep();
        }

        private void InitializeWizardSteps()
        {
            // Inicializa los formularios de cada paso del wizard
            wizardSteps = new Form[]
            {
                new Step1Form(),
                new Step2Form(),
                new Step3Form()
            };

            foreach (Form step in wizardSteps)
            {
                step.TopLevel = false;
                step.FormBorderStyle = FormBorderStyle.None;
                step.Dock = DockStyle.Fill;
                pnlCodeContainer.Controls.Add(step);
            }
        }

        private void ShowCurrentStep()
        {
            // Oculta todos los formularios del wizard y muestra el formulario correspondiente al paso actual
            foreach (Form step in wizardSteps)
            {
                step.Hide();
            }

            wizardSteps[currentStep - 1].Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Navega al siguiente paso del wizard
            if (currentStep < wizardSteps.Length)
            {
                currentStep++;
                ShowCurrentStep();
            }
            else
            {
                // Si estamos en el último paso, podrías ejecutar alguna acción final aquí
                MessageBox.Show("¡Felicidades! Has completado el wizard.");
                this.Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Navega al paso anterior del wizard
            if (currentStep > 1)
            {
                currentStep--;
                ShowCurrentStep();
            }
        }
    }
}
