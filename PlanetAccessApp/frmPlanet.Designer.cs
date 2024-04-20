
namespace PlanetAccessApp
{
    partial class frmPlanet
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnGenerateFiles = new System.Windows.Forms.Button();
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
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(12, 12);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(225, 98);
            this.btnVerify.TabIndex = 3;
            this.btnVerify.Text = "Verify Codes";
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(243, 167);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(225, 98);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt and Send";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnGenerateFiles
            // 
            this.btnGenerateFiles.Location = new System.Drawing.Point(12, 167);
            this.btnGenerateFiles.Name = "btnGenerateFiles";
            this.btnGenerateFiles.Size = new System.Drawing.Size(225, 98);
            this.btnGenerateFiles.TabIndex = 3;
            this.btnGenerateFiles.Text = "Generate Files";
            this.btnGenerateFiles.UseVisualStyleBackColor = true;
            // 
            // frmPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 547);
            this.Controls.Add(this.btnGenerateFiles);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtSpaceshipTerminal);
            this.Name = "frmPlanet";
            this.Text = "Planet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSpaceshipTerminal;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnGenerateFiles;
    }
}