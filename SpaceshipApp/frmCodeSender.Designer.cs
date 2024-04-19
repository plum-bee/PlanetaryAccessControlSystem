namespace SpaceshipApp
{
    partial class frmCodeSender
    {
        private System.Windows.Forms.Panel pnlCodeContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSpaceshipCode;
        private System.Windows.Forms.TextBox txtSpaceshipCode;
        private System.Windows.Forms.TextBox txtDeliveryCode;
        private System.Windows.Forms.Label lblDeliveryCode;
        private void InitializeComponent()
        {
            this.pnlCodeContainer = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSpaceshipCode = new System.Windows.Forms.Label();
            this.txtSpaceshipCode = new System.Windows.Forms.TextBox();
            this.txtDeliveryCode = new System.Windows.Forms.TextBox();
            this.lblDeliveryCode = new System.Windows.Forms.Label();
            this.pnlCodeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCodeContainer
            // 
            this.pnlCodeContainer.Controls.Add(this.btnSend);
            this.pnlCodeContainer.Controls.Add(this.lblSpaceshipCode);
            this.pnlCodeContainer.Controls.Add(this.txtSpaceshipCode);
            this.pnlCodeContainer.Controls.Add(this.txtDeliveryCode);
            this.pnlCodeContainer.Controls.Add(this.lblDeliveryCode);
            this.pnlCodeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCodeContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlCodeContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCodeContainer.Name = "pnlCodeContainer";
            this.pnlCodeContainer.Size = new System.Drawing.Size(1067, 554);
            this.pnlCodeContainer.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSend.Location = new System.Drawing.Point(76, 451);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 40);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // lblSpaceshipCode
            // 
            this.lblSpaceshipCode.AutoSize = true;
            this.lblSpaceshipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSpaceshipCode.Location = new System.Drawing.Point(73, 160);
            this.lblSpaceshipCode.Name = "lblSpaceshipCode";
            this.lblSpaceshipCode.Size = new System.Drawing.Size(168, 25);
            this.lblSpaceshipCode.TabIndex = 2;
            this.lblSpaceshipCode.Text = "Spaceship Codes";
            // 
            // txtSpaceshipCode
            // 
            this.txtSpaceshipCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSpaceshipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSpaceshipCode.Location = new System.Drawing.Point(76, 194);
            this.txtSpaceshipCode.Name = "txtSpaceshipCode";
            this.txtSpaceshipCode.Size = new System.Drawing.Size(486, 30);
            this.txtSpaceshipCode.TabIndex = 3;
            // 
            // txtDeliveryCode
            // 
            this.txtDeliveryCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeliveryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDeliveryCode.Location = new System.Drawing.Point(76, 85);
            this.txtDeliveryCode.Name = "txtDeliveryCode";
            this.txtDeliveryCode.Size = new System.Drawing.Size(486, 30);
            this.txtDeliveryCode.TabIndex = 1;
            // 
            // lblDeliveryCode
            // 
            this.lblDeliveryCode.AutoSize = true;
            this.lblDeliveryCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDeliveryCode.Location = new System.Drawing.Point(73, 54);
            this.lblDeliveryCode.Name = "lblDeliveryCode";
            this.lblDeliveryCode.Size = new System.Drawing.Size(135, 25);
            this.lblDeliveryCode.TabIndex = 0;
            this.lblDeliveryCode.Text = "Delivery Code";
            // 
            // frmCodeSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlCodeContainer);
            this.Name = "frmCodeSender";
            this.Text = "Spaceship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCodeContainer.ResumeLayout(false);
            this.pnlCodeContainer.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
