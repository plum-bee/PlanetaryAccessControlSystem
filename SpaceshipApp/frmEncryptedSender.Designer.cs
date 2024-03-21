
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
            this.pnlEncryptedContainer = new System.Windows.Forms.Panel();
            this.pgbDownload = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDownloadKeyFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblValidationCode = new System.Windows.Forms.Label();
            this.txtValidationCode = new System.Windows.Forms.TextBox();
            this.lblPubKeyPath = new System.Windows.Forms.Label();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.pnlEncryptedContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1070, 639);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlEncryptedContainer
            // 
            this.pnlEncryptedContainer.Controls.Add(this.txtPlanet);
            this.pnlEncryptedContainer.Controls.Add(this.pgbDownload);
            this.pnlEncryptedContainer.Controls.Add(this.button1);
            this.pnlEncryptedContainer.Controls.Add(this.btnDownloadKeyFile);
            this.pnlEncryptedContainer.Controls.Add(this.btnSend);
            this.pnlEncryptedContainer.Controls.Add(this.lblValidationCode);
            this.pnlEncryptedContainer.Controls.Add(this.txtValidationCode);
            this.pnlEncryptedContainer.Controls.Add(this.lblPubKeyPath);
            this.pnlEncryptedContainer.Location = new System.Drawing.Point(18, 19);
            this.pnlEncryptedContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEncryptedContainer.Name = "pnlEncryptedContainer";
            this.pnlEncryptedContainer.Size = new System.Drawing.Size(1164, 611);
            this.pnlEncryptedContainer.TabIndex = 2;
            // 
            // pgbDownload
            // 
            this.pgbDownload.Location = new System.Drawing.Point(86, 178);
            this.pgbDownload.Name = "pgbDownload";
            this.pgbDownload.Size = new System.Drawing.Size(510, 23);
            this.pgbDownload.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDownloadKeyFile
            // 
            this.btnDownloadKeyFile.Location = new System.Drawing.Point(621, 169);
            this.btnDownloadKeyFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownloadKeyFile.Name = "btnDownloadKeyFile";
            this.btnDownloadKeyFile.Size = new System.Drawing.Size(198, 37);
            this.btnDownloadKeyFile.TabIndex = 2;
            this.btnDownloadKeyFile.Text = "Download Planet Key";
            this.btnDownloadKeyFile.UseVisualStyleBackColor = true;
            this.btnDownloadKeyFile.Click += new System.EventHandler(this.btnDownloadKeyFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(86, 482);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 29);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblValidationCode
            // 
            this.lblValidationCode.AutoSize = true;
            this.lblValidationCode.Location = new System.Drawing.Point(82, 291);
            this.lblValidationCode.Name = "lblValidationCode";
            this.lblValidationCode.Size = new System.Drawing.Size(121, 20);
            this.lblValidationCode.TabIndex = 2;
            this.lblValidationCode.Text = "Validation Code";
            // 
            // txtValidationCode
            // 
            this.txtValidationCode.Location = new System.Drawing.Point(86, 333);
            this.txtValidationCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtValidationCode.Name = "txtValidationCode";
            this.txtValidationCode.Size = new System.Drawing.Size(510, 26);
            this.txtValidationCode.TabIndex = 3;
            // 
            // lblPubKeyPath
            // 
            this.lblPubKeyPath.AutoSize = true;
            this.lblPubKeyPath.Location = new System.Drawing.Point(82, 91);
            this.lblPubKeyPath.Name = "lblPubKeyPath";
            this.lblPubKeyPath.Size = new System.Drawing.Size(159, 20);
            this.lblPubKeyPath.TabIndex = 0;
            this.lblPubKeyPath.Text = "Planet Delivery Name";
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(86, 133);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(510, 26);
            this.txtPlanet.TabIndex = 1;
            // 
            // frmEncryptedSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlEncryptedContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEncryptedSender";
            this.Text = "Spaceship";
            this.pnlEncryptedContainer.ResumeLayout(false);
            this.pnlEncryptedContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlEncryptedContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblValidationCode;
        private System.Windows.Forms.TextBox txtValidationCode;
        private System.Windows.Forms.Label lblPubKeyPath;
        private System.Windows.Forms.Button btnDownloadKeyFile;
        private System.Windows.Forms.ProgressBar pgbDownload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPlanet;
    }
}