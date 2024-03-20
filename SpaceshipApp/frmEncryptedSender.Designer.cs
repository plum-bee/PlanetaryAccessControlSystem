
namespace SpaceshipApp
{
    partial class frmEncryptedSender
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
            this.lblValidationCode = new System.Windows.Forms.Label();
            this.txtSpaceshipCode = new System.Windows.Forms.TextBox();
            this.txtDeliveryCode = new System.Windows.Forms.TextBox();
            this.lblPubKeyPath = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlWizardContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(951, 511);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlWizardContainer
            // 
            this.pnlWizardContainer.Controls.Add(this.button1);
            this.pnlWizardContainer.Controls.Add(this.btnSend);
            this.pnlWizardContainer.Controls.Add(this.lblValidationCode);
            this.pnlWizardContainer.Controls.Add(this.txtSpaceshipCode);
            this.pnlWizardContainer.Controls.Add(this.txtDeliveryCode);
            this.pnlWizardContainer.Controls.Add(this.lblPubKeyPath);
            this.pnlWizardContainer.Location = new System.Drawing.Point(16, 15);
            this.pnlWizardContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWizardContainer.Name = "pnlWizardContainer";
            this.pnlWizardContainer.Size = new System.Drawing.Size(1035, 489);
            this.pnlWizardContainer.TabIndex = 2;
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
            // lblValidationCode
            // 
            this.lblValidationCode.AutoSize = true;
            this.lblValidationCode.Location = new System.Drawing.Point(73, 160);
            this.lblValidationCode.Name = "lblValidationCode";
            this.lblValidationCode.Size = new System.Drawing.Size(107, 17);
            this.lblValidationCode.TabIndex = 2;
            this.lblValidationCode.Text = "Validation Code";
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
            // lblPubKeyPath
            // 
            this.lblPubKeyPath.AutoSize = true;
            this.lblPubKeyPath.Location = new System.Drawing.Point(73, 54);
            this.lblPubKeyPath.Name = "lblPubKeyPath";
            this.lblPubKeyPath.Size = new System.Drawing.Size(128, 17);
            this.lblPubKeyPath.TabIndex = 0;
            this.lblPubKeyPath.Text = "Public Key file path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEncryptedSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlWizardContainer);
            this.Name = "frmEncryptedSender";
            this.Text = "Spaceship";
            this.pnlWizardContainer.ResumeLayout(false);
            this.pnlWizardContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlWizardContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblValidationCode;
        private System.Windows.Forms.TextBox txtSpaceshipCode;
        private System.Windows.Forms.TextBox txtDeliveryCode;
        private System.Windows.Forms.Label lblPubKeyPath;
        private System.Windows.Forms.Button button1;
    }
}