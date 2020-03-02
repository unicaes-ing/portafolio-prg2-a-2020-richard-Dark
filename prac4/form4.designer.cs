namespace form4
{
    partial class form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 3";
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(191, 254);
            this.btnMayor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(100, 28);
            this.btnMayor.TabIndex = 3;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(191, 81);
            this.txtNumero1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(132, 22);
            this.txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(191, 145);
            this.txtNumero2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(132, 22);
            this.txtNumero2.TabIndex = 5;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(191, 202);
            this.txtNumero3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(132, 22);
            this.txtNumero3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mayor";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(173, 327);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(0, 17);
            this.lblMayor.TabIndex = 8;
            // 
            // ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 367);
            this.Controls.Add(this.lblMayor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ejercicio4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMayor;
    }
}