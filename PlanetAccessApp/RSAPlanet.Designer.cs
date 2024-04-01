
namespace PlanetAccessApp
{
    partial class RSAPlanet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_keys = new System.Windows.Forms.Panel();
            this.txtPlanet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKeyContainer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(49, 152);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(140, 58);
            this.btn_generate.TabIndex = 22;
            this.btn_generate.Text = "Generate and Upload Keys";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "RSA Keys";
            // 
            // pnl_keys
            // 
            this.pnl_keys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_keys.Controls.Add(this.btn_generate);
            this.pnl_keys.Controls.Add(this.txtPlanet);
            this.pnl_keys.Controls.Add(this.label4);
            this.pnl_keys.Controls.Add(this.txtKeyContainer);
            this.pnl_keys.Controls.Add(this.label2);
            this.pnl_keys.Location = new System.Drawing.Point(24, 73);
            this.pnl_keys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_keys.Name = "pnl_keys";
            this.pnl_keys.Size = new System.Drawing.Size(712, 227);
            this.pnl_keys.TabIndex = 23;
            // 
            // txtPlanet
            // 
            this.txtPlanet.Location = new System.Drawing.Point(213, 99);
            this.txtPlanet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlanet.Name = "txtPlanet";
            this.txtPlanet.Size = new System.Drawing.Size(430, 26);
            this.txtPlanet.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination Planet";
            // 
            // txtKeyContainer
            // 
            this.txtKeyContainer.Location = new System.Drawing.Point(213, 45);
            this.txtKeyContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyContainer.Name = "txtKeyContainer";
            this.txtKeyContainer.Size = new System.Drawing.Size(188, 26);
            this.txtKeyContainer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "KeyContainer Name";
            // 
            // RSAPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_keys);
            this.Name = "RSAPlanet";
            this.Text = "RSA Planet";
            this.pnl_keys.ResumeLayout(false);
            this.pnl_keys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_keys;
        private System.Windows.Forms.TextBox txtPlanet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKeyContainer;
        private System.Windows.Forms.Label label2;
    }
}

