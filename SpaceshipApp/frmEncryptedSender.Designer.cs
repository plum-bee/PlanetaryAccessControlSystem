
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
            this.pgbEncryption = new System.Windows.Forms.ProgressBar();
            this.btnEncryptCode = new System.Windows.Forms.Button();
            this.btnValidationCode = new System.Windows.Forms.Button();
            this.pgbDownloadCode = new System.Windows.Forms.ProgressBar();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.pgbDownloadKey = new System.Windows.Forms.ProgressBar();
            this.btnSelectCode = new System.Windows.Forms.Button();
            this.btnDownloadKeyFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblValidationCode = new System.Windows.Forms.Label();
            this.txtValidationCode = new System.Windows.Forms.TextBox();
            this.lblPubKeyPath = new System.Windows.Forms.Label();
            this.txtPlanetKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectKey = new System.Windows.Forms.Button();
            this.txtEncryptedCode = new System.Windows.Forms.TextBox();
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
            this.pnlEncryptedContainer.Controls.Add(this.txtEncryptedCode);
            this.pnlEncryptedContainer.Controls.Add(this.btnSelectKey);
            this.pnlEncryptedContainer.Controls.Add(this.label1);
            this.pnlEncryptedContainer.Controls.Add(this.txtPlanetKey);
            this.pnlEncryptedContainer.Controls.Add(this.pgbEncryption);
            this.pnlEncryptedContainer.Controls.Add(this.btnEncryptCode);
            this.pnlEncryptedContainer.Controls.Add(this.btnValidationCode);
            this.pnlEncryptedContainer.Controls.Add(this.pgbDownloadCode);
            this.pnlEncryptedContainer.Controls.Add(this.txtPlanet);
            this.pnlEncryptedContainer.Controls.Add(this.pgbDownloadKey);
            this.pnlEncryptedContainer.Controls.Add(this.btnSelectCode);
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
            // pgbEncryption
            // 
            this.pgbEncryption.Location = new System.Drawing.Point(86, 463);
            this.pgbEncryption.Name = "pgbEncryption";
            this.pgbEncryption.Size = new System.Drawing.Size(510, 23);
            this.pgbEncryption.TabIndex = 11;
            // 
            // btnEncryptCode
            // 
            this.btnEncryptCode.Location = new System.Drawing.Point(621, 463);
            this.btnEncryptCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncryptCode.Name = "btnEncryptCode";
            this.btnEncryptCode.Size = new System.Drawing.Size(221, 37);
            this.btnEncryptCode.TabIndex = 10;
            this.btnEncryptCode.Text = "Encrypt Validation Code";
            this.btnEncryptCode.UseVisualStyleBackColor = true;
            this.btnEncryptCode.Click += new System.EventHandler(this.btnEncryptCode_Click);
            // 
            // btnValidationCode
            // 
            this.btnValidationCode.Location = new System.Drawing.Point(621, 228);
            this.btnValidationCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnValidationCode.Name = "btnValidationCode";
            this.btnValidationCode.Size = new System.Drawing.Size(221, 37);
            this.btnValidationCode.TabIndex = 9;
            this.btnValidationCode.Text = "Download Validation Code";
            this.btnValidationCode.UseVisualStyleBackColor = true;
            this.btnValidationCode.Click += new System.EventHandler(this.btnValidationCode_Click);
            // 
            // pgbDownloadCode
            // 
            this.pgbDownloadCode.Location = new System.Drawing.Point(86, 228);
            this.pgbDownloadCode.Name = "pgbDownloadCode";
            this.pgbDownloadCode.Size = new System.Drawing.Size(510, 23);
            this.pgbDownloadCode.TabIndex = 8;
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(86, 133);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(510, 26);
            this.txtPlanet.TabIndex = 1;
            // 
            // pgbDownloadKey
            // 
            this.pgbDownloadKey.Location = new System.Drawing.Point(86, 178);
            this.pgbDownloadKey.Name = "pgbDownloadKey";
            this.pgbDownloadKey.Size = new System.Drawing.Size(510, 23);
            this.pgbDownloadKey.TabIndex = 7;
            // 
            // btnSelectCode
            // 
            this.btnSelectCode.Location = new System.Drawing.Point(621, 324);
            this.btnSelectCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectCode.Name = "btnSelectCode";
            this.btnSelectCode.Size = new System.Drawing.Size(76, 29);
            this.btnSelectCode.TabIndex = 6;
            this.btnSelectCode.Text = "...";
            this.btnSelectCode.UseVisualStyleBackColor = true;
            this.btnSelectCode.Click += new System.EventHandler(this.btnSelectCode_Click);
            // 
            // btnDownloadKeyFile
            // 
            this.btnDownloadKeyFile.Location = new System.Drawing.Point(621, 169);
            this.btnDownloadKeyFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownloadKeyFile.Name = "btnDownloadKeyFile";
            this.btnDownloadKeyFile.Size = new System.Drawing.Size(221, 37);
            this.btnDownloadKeyFile.TabIndex = 2;
            this.btnDownloadKeyFile.Text = "Download Planet Key";
            this.btnDownloadKeyFile.UseVisualStyleBackColor = true;
            this.btnDownloadKeyFile.Click += new System.EventHandler(this.btnDownloadKeyFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(86, 518);
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
            this.txtValidationCode.Location = new System.Drawing.Point(86, 327);
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
            // txtPlanetKey
            // 
            this.txtPlanetKey.Location = new System.Drawing.Point(86, 408);
            this.txtPlanetKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlanetKey.Name = "txtPlanetKey";
            this.txtPlanetKey.Size = new System.Drawing.Size(510, 26);
            this.txtPlanetKey.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Planet Key";
            // 
            // btnSelectKey
            // 
            this.btnSelectKey.Location = new System.Drawing.Point(621, 408);
            this.btnSelectKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectKey.Name = "btnSelectKey";
            this.btnSelectKey.Size = new System.Drawing.Size(76, 29);
            this.btnSelectKey.TabIndex = 14;
            this.btnSelectKey.Text = "...";
            this.btnSelectKey.UseVisualStyleBackColor = true;
            this.btnSelectKey.Click += new System.EventHandler(this.btnSelectKey_Click);
            // 
            // txtEncryptedCode
            // 
            this.txtEncryptedCode.Location = new System.Drawing.Point(720, 411);
            this.txtEncryptedCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEncryptedCode.Name = "txtEncryptedCode";
            this.txtEncryptedCode.Size = new System.Drawing.Size(354, 26);
            this.txtEncryptedCode.TabIndex = 15;
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
        private System.Windows.Forms.ProgressBar pgbDownloadKey;
        private System.Windows.Forms.Button btnSelectCode;
        private System.Windows.Forms.TextBox txtPlanet;
        private System.Windows.Forms.Button btnValidationCode;
        private System.Windows.Forms.ProgressBar pgbDownloadCode;
        private System.Windows.Forms.ProgressBar pgbEncryption;
        private System.Windows.Forms.Button btnEncryptCode;
        private System.Windows.Forms.Button btnSelectKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlanetKey;
        private System.Windows.Forms.TextBox txtEncryptedCode;
    }
}