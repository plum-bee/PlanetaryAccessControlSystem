﻿
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_routeXML = new System.Windows.Forms.Button();
            this.txtRouteXML = new System.Windows.Forms.TextBox();
            this.txtKeyContainer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_keys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(24, 329);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(140, 58);
            this.btn_generate.TabIndex = 22;
            this.btn_generate.Text = "Generate and Upload Keys";
            this.btn_generate.UseVisualStyleBackColor = true;
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
            this.pnl_keys.Controls.Add(this.textBox1);
            this.pnl_keys.Controls.Add(this.label4);
            this.pnl_keys.Controls.Add(this.btn_routeXML);
            this.pnl_keys.Controls.Add(this.txtRouteXML);
            this.pnl_keys.Controls.Add(this.txtKeyContainer);
            this.pnl_keys.Controls.Add(this.label3);
            this.pnl_keys.Controls.Add(this.label2);
            this.pnl_keys.Location = new System.Drawing.Point(24, 73);
            this.pnl_keys.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnl_keys.Name = "pnl_keys";
            this.pnl_keys.Size = new System.Drawing.Size(752, 227);
            this.pnl_keys.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 148);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 26);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination Planet";
            // 
            // btn_routeXML
            // 
            this.btn_routeXML.Location = new System.Drawing.Point(660, 92);
            this.btn_routeXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_routeXML.Name = "btn_routeXML";
            this.btn_routeXML.Size = new System.Drawing.Size(51, 35);
            this.btn_routeXML.TabIndex = 6;
            this.btn_routeXML.Text = "...";
            this.btn_routeXML.UseVisualStyleBackColor = true;
            // 
            // txtRouteXML
            // 
            this.txtRouteXML.Location = new System.Drawing.Point(213, 96);
            this.txtRouteXML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRouteXML.Name = "txtRouteXML";
            this.txtRouteXML.Size = new System.Drawing.Size(430, 26);
            this.txtRouteXML.TabIndex = 5;
            // 
            // txtKeyContainer
            // 
            this.txtKeyContainer.Location = new System.Drawing.Point(213, 45);
            this.txtKeyContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKeyContainer.Name = "txtKeyContainer";
            this.txtKeyContainer.Size = new System.Drawing.Size(188, 26);
            this.txtKeyContainer.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "XML Public Key";
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
            this.ClientSize = new System.Drawing.Size(819, 407);
            this.Controls.Add(this.btn_generate);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_routeXML;
        private System.Windows.Forms.TextBox txtRouteXML;
        private System.Windows.Forms.TextBox txtKeyContainer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

