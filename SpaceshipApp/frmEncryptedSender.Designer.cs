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
            this.pnlEncryptedContainer = new System.Windows.Forms.Panel();
            this.txtEncryptedCode = new System.Windows.Forms.TextBox();
            this.btnSelectKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlanetKey = new System.Windows.Forms.TextBox();
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
            this.pnlEncryptedContainer.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlEncryptedContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEncryptedContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pnlEncryptedContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlEncryptedContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEncryptedContainer.Name = "pnlEncryptedContainer";
            this.pnlEncryptedContainer.Size = new System.Drawing.Size(1541, 813);
            this.pnlEncryptedContainer.TabIndex = 0;
            // 
            // txtEncryptedCode
            // 
            this.txtEncryptedCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncryptedCode.Location = new System.Drawing.Point(65, 551);
            this.txtEncryptedCode.Name = "txtEncryptedCode";
            this.txtEncryptedCode.Size = new System.Drawing.Size(997, 30);
            this.txtEncryptedCode.TabIndex = 15;
            // 
            // btnSelectKey
            // 
            this.btnSelectKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectKey.Location = new System.Drawing.Point(1081, 469);
            this.btnSelectKey.Name = "btnSelectKey";
            this.btnSelectKey.Size = new System.Drawing.Size(67, 30);
            this.btnSelectKey.TabIndex = 14;
            this.btnSelectKey.Text = "...";
            this.btnSelectKey.UseVisualStyleBackColor = true;
            this.btnSelectKey.Click += new System.EventHandler(this.btnSelectKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Planet Key";
            // 
            // txtPlanetKey
            // 
            this.txtPlanetKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanetKey.Location = new System.Drawing.Point(65, 469);
            this.txtPlanetKey.Name = "txtPlanetKey";
            this.txtPlanetKey.Size = new System.Drawing.Size(997, 30);
            this.txtPlanetKey.TabIndex = 12;
            // 
            // pgbEncryption
            // 
            this.pgbEncryption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbEncryption.Location = new System.Drawing.Point(65, 621);
            this.pgbEncryption.Name = "pgbEncryption";
            this.pgbEncryption.Size = new System.Drawing.Size(996, 16);
            this.pgbEncryption.TabIndex = 11;
            // 
            // btnEncryptCode
            // 
            this.btnEncryptCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncryptCode.Location = new System.Drawing.Point(1081, 621);
            this.btnEncryptCode.Name = "btnEncryptCode";
            this.btnEncryptCode.Size = new System.Drawing.Size(215, 36);
            this.btnEncryptCode.TabIndex = 10;
            this.btnEncryptCode.Text = "Encrypt Validation Code";
            this.btnEncryptCode.UseVisualStyleBackColor = true;
            this.btnEncryptCode.Click += new System.EventHandler(this.btnEncryptCode_Click);
            // 
            // btnValidationCode
            // 
            this.btnValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidationCode.Location = new System.Drawing.Point(1082, 273);
            this.btnValidationCode.Name = "btnValidationCode";
            this.btnValidationCode.Size = new System.Drawing.Size(215, 36);
            this.btnValidationCode.TabIndex = 9;
            this.btnValidationCode.Text = "Download Validation Code";
            this.btnValidationCode.UseVisualStyleBackColor = true;
            this.btnValidationCode.Click += new System.EventHandler(this.btnValidationCode_Click);
            // 
            // pgbDownloadCode
            // 
            this.pgbDownloadCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbDownloadCode.Location = new System.Drawing.Point(68, 273);
            this.pgbDownloadCode.Name = "pgbDownloadCode";
            this.pgbDownloadCode.Size = new System.Drawing.Size(996, 16);
            this.pgbDownloadCode.TabIndex = 8;
            // 
            // txtPlanet
            // 
            this.txtPlanet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPlanet.Location = new System.Drawing.Point(65, 111);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(997, 30);
            this.txtPlanet.TabIndex = 1;
            // 
            // pgbDownloadKey
            // 
            this.pgbDownloadKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgbDownloadKey.Location = new System.Drawing.Point(67, 207);
            this.pgbDownloadKey.Name = "pgbDownloadKey";
            this.pgbDownloadKey.Size = new System.Drawing.Size(996, 16);
            this.pgbDownloadKey.TabIndex = 7;
            // 
            // btnSelectCode
            // 
            this.btnSelectCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectCode.Location = new System.Drawing.Point(1082, 365);
            this.btnSelectCode.Name = "btnSelectCode";
            this.btnSelectCode.Size = new System.Drawing.Size(67, 30);
            this.btnSelectCode.TabIndex = 6;
            this.btnSelectCode.Text = "...";
            this.btnSelectCode.UseVisualStyleBackColor = true;
            this.btnSelectCode.Click += new System.EventHandler(this.btnSelectCode_Click);
            // 
            // btnDownloadKeyFile
            // 
            this.btnDownloadKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadKeyFile.Location = new System.Drawing.Point(1082, 207);
            this.btnDownloadKeyFile.Name = "btnDownloadKeyFile";
            this.btnDownloadKeyFile.Size = new System.Drawing.Size(215, 36);
            this.btnDownloadKeyFile.TabIndex = 2;
            this.btnDownloadKeyFile.Text = "Download Planet Key";
            this.btnDownloadKeyFile.UseVisualStyleBackColor = true;
            this.btnDownloadKeyFile.Click += new System.EventHandler(this.btnDownloadKeyFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(68, 760);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 41);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblValidationCode
            // 
            this.lblValidationCode.AutoSize = true;
            this.lblValidationCode.Location = new System.Drawing.Point(63, 342);
            this.lblValidationCode.Name = "lblValidationCode";
            this.lblValidationCode.Size = new System.Drawing.Size(151, 25);
            this.lblValidationCode.TabIndex = 2;
            this.lblValidationCode.Text = "Validation Code";
            // 
            // txtValidationCode
            // 
            this.txtValidationCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValidationCode.Location = new System.Drawing.Point(66, 368);
            this.txtValidationCode.Name = "txtValidationCode";
            this.txtValidationCode.Size = new System.Drawing.Size(997, 30);
            this.txtValidationCode.TabIndex = 3;
            // 
            // lblPubKeyPath
            // 
            this.lblPubKeyPath.AutoSize = true;
            this.lblPubKeyPath.Location = new System.Drawing.Point(63, 69);
            this.lblPubKeyPath.Name = "lblPubKeyPath";
            this.lblPubKeyPath.Size = new System.Drawing.Size(199, 25);
            this.lblPubKeyPath.TabIndex = 0;
            this.lblPubKeyPath.Text = "Planet Delivery Name";
            // 
            // frmEncryptedSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 813);
            this.Controls.Add(this.pnlEncryptedContainer);
            this.Name = "frmEncryptedSender";
            this.Text = "Spaceship Secure Transmission";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlEncryptedContainer.ResumeLayout(false);
            this.pnlEncryptedContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
