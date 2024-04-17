
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
            this.pnlCodeContainer = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSpaceshipCode = new System.Windows.Forms.Label();
            this.txtSpaceshipCode = new System.Windows.Forms.TextBox();
            this.txtDeliveryCode = new System.Windows.Forms.TextBox();
            this.lblDeliveryCode = new System.Windows.Forms.Label();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.pnlCodeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1070, 639);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // pnlCodeContainer
            // 
            this.pnlCodeContainer.Controls.Add(this.lbx_console);
            this.pnlCodeContainer.Controls.Add(this.btnSend);
            this.pnlCodeContainer.Controls.Add(this.lblSpaceshipCode);
            this.pnlCodeContainer.Controls.Add(this.txtSpaceshipCode);
            this.pnlCodeContainer.Controls.Add(this.txtDeliveryCode);
            this.pnlCodeContainer.Controls.Add(this.lblDeliveryCode);
            this.pnlCodeContainer.Location = new System.Drawing.Point(18, 19);
            this.pnlCodeContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCodeContainer.Name = "pnlCodeContainer";
            this.pnlCodeContainer.Size = new System.Drawing.Size(1164, 611);
            this.pnlCodeContainer.TabIndex = 0;
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
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblSpaceshipCode
            // 
            this.lblSpaceshipCode.AutoSize = true;
            this.lblSpaceshipCode.Location = new System.Drawing.Point(82, 200);
            this.lblSpaceshipCode.Name = "lblSpaceshipCode";
            this.lblSpaceshipCode.Size = new System.Drawing.Size(134, 20);
            this.lblSpaceshipCode.TabIndex = 2;
            this.lblSpaceshipCode.Text = "Spaceship Codes";
            // 
            // txtSpaceshipCode
            // 
            this.txtSpaceshipCode.Location = new System.Drawing.Point(86, 242);
            this.txtSpaceshipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSpaceshipCode.Name = "txtSpaceshipCode";
            this.txtSpaceshipCode.Size = new System.Drawing.Size(510, 26);
            this.txtSpaceshipCode.TabIndex = 3;
            // 
            // txtDeliveryCode
            // 
            this.txtDeliveryCode.Location = new System.Drawing.Point(86, 106);
            this.txtDeliveryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryCode.Name = "txtDeliveryCode";
            this.txtDeliveryCode.Size = new System.Drawing.Size(510, 26);
            this.txtDeliveryCode.TabIndex = 1;
            // 
            // lblDeliveryCode
            // 
            this.lblDeliveryCode.AutoSize = true;
            this.lblDeliveryCode.Location = new System.Drawing.Point(82, 68);
            this.lblDeliveryCode.Name = "lblDeliveryCode";
            this.lblDeliveryCode.Size = new System.Drawing.Size(106, 20);
            this.lblDeliveryCode.TabIndex = 0;
            this.lblDeliveryCode.Text = "Delivery Code";
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Window;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 20;
            this.lbx_console.Location = new System.Drawing.Point(664, 106);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(446, 304);
            this.lbx_console.TabIndex = 5;
            // 
            // frmCodeSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlCodeContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCodeSender";
            this.Text = "Spaceship";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCodeContainer.ResumeLayout(false);
            this.pnlCodeContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlCodeContainer;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSpaceshipCode;
        private System.Windows.Forms.TextBox txtSpaceshipCode;
        private System.Windows.Forms.TextBox txtDeliveryCode;
        private System.Windows.Forms.Label lblDeliveryCode;
        private System.Windows.Forms.ListBox lbx_console;
    }
}

