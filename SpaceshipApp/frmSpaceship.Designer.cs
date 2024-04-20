
namespace SpaceshipApp
{
    partial class frmSpaceship
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
            this.txtSpaceshipTerminal = new System.Windows.Forms.TextBox();
            this.pnlConnectionStatus = new System.Windows.Forms.Panel();
            this.cmbPlanets = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSpaceshipTerminal
            // 
            this.txtSpaceshipTerminal.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtSpaceshipTerminal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpaceshipTerminal.ForeColor = System.Drawing.Color.Lime;
            this.txtSpaceshipTerminal.Location = new System.Drawing.Point(474, 12);
            this.txtSpaceshipTerminal.Multiline = true;
            this.txtSpaceshipTerminal.Name = "txtSpaceshipTerminal";
            this.txtSpaceshipTerminal.Size = new System.Drawing.Size(552, 523);
            this.txtSpaceshipTerminal.TabIndex = 0;
            // 
            // pnlConnectionStatus
            // 
            this.pnlConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.pnlConnectionStatus.Location = new System.Drawing.Point(418, 12);
            this.pnlConnectionStatus.Name = "pnlConnectionStatus";
            this.pnlConnectionStatus.Size = new System.Drawing.Size(50, 50);
            this.pnlConnectionStatus.TabIndex = 1;
            // 
            // cmbPlanets
            // 
            this.cmbPlanets.FormattingEnabled = true;
            this.cmbPlanets.Location = new System.Drawing.Point(12, 11);
            this.cmbPlanets.Name = "cmbPlanets";
            this.cmbPlanets.Size = new System.Drawing.Size(150, 24);
            this.cmbPlanets.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(209, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(181, 51);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(12, 127);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(225, 98);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download ValidationCode\r\nand EncryptionData\r\n";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(243, 303);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(225, 98);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt and Send";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(12, 303);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(225, 98);
            this.btnDecode.TabIndex = 3;
            this.btnDecode.Text = "Decode and Send";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // frmSpaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 547);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbPlanets);
            this.Controls.Add(this.pnlConnectionStatus);
            this.Controls.Add(this.txtSpaceshipTerminal);
            this.Name = "frmSpaceship";
            this.Text = "Spaceship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpaceshipTerminal;
        private System.Windows.Forms.Panel pnlConnectionStatus;
        private System.Windows.Forms.ComboBox cmbPlanets;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecode;
    }
}