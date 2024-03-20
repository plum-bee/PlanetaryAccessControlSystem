
namespace SpaceshipApp
{
    partial class frmCodeSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlWizardContainer = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSpaceshipCode = new System.Windows.Forms.Label();
            this.txtSpaceshipCode = new System.Windows.Forms.TextBox();
            this.txtDeliveryCode = new System.Windows.Forms.TextBox();
            this.lblDeliveryCode = new System.Windows.Forms.Label();
            this.pnlWizardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(951, 511);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlWizardContainer
            // 
            this.pnlWizardContainer.Controls.Add(this.btnSend);
            this.pnlWizardContainer.Controls.Add(this.lblSpaceshipCode);
            this.pnlWizardContainer.Controls.Add(this.txtSpaceshipCode);
            this.pnlWizardContainer.Controls.Add(this.txtDeliveryCode);
            this.pnlWizardContainer.Controls.Add(this.lblDeliveryCode);
            this.pnlWizardContainer.Location = new System.Drawing.Point(16, 15);
            this.pnlWizardContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWizardContainer.Name = "pnlWizardContainer";
            this.pnlWizardContainer.Size = new System.Drawing.Size(1035, 489);
            this.pnlWizardContainer.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(76, 386);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblSpaceshipCode
            // 
            this.lblSpaceshipCode.AutoSize = true;
            this.lblSpaceshipCode.Location = new System.Drawing.Point(73, 160);
            this.lblSpaceshipCode.Name = "lblSpaceshipCode";
            this.lblSpaceshipCode.Size = new System.Drawing.Size(111, 17);
            this.lblSpaceshipCode.TabIndex = 2;
            this.lblSpaceshipCode.Text = "Spaceship Code";
            // 
            // txtSpaceshipCode
            // 
            this.txtSpaceshipCode.Location = new System.Drawing.Point(76, 194);
            this.txtSpaceshipCode.Name = "txtSpaceshipCode";
            this.txtSpaceshipCode.Size = new System.Drawing.Size(454, 22);
            this.txtSpaceshipCode.TabIndex = 3;
            // 
            // txtDeliveryCode
            // 
            this.txtDeliveryCode.Location = new System.Drawing.Point(76, 85);
            this.txtDeliveryCode.Name = "txtDeliveryCode";
            this.txtDeliveryCode.Size = new System.Drawing.Size(454, 22);
            this.txtDeliveryCode.TabIndex = 1;
            // 
            // lblDeliveryCode
            // 
            this.lblDeliveryCode.AutoSize = true;
            this.lblDeliveryCode.Location = new System.Drawing.Point(73, 54);
            this.lblDeliveryCode.Name = "lblDeliveryCode";
            this.lblDeliveryCode.Size = new System.Drawing.Size(96, 17);
            this.lblDeliveryCode.TabIndex = 0;
            this.lblDeliveryCode.Text = "Delivery Code";
            // 
            // frmCodeSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlWizardContainer);
            this.Name = "frmCodeSender";
            this.Text = "Spaceship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlWizardContainer.ResumeLayout(false);
            this.pnlWizardContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlWizardContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSpaceshipCode;
        private System.Windows.Forms.TextBox txtSpaceshipCode;
        private System.Windows.Forms.TextBox txtDeliveryCode;
        private System.Windows.Forms.Label lblDeliveryCode;
    }
}

