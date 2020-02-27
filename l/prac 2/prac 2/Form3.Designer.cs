namespace prac_2
{
    partial class Form3
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpDE = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grpA = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtLongaConvert = new System.Windows.Forms.TextBox();
            this.txtLongConvert = new System.Windows.Forms.TextBox();
            this.grpDE.SuspendLayout();
            this.grpA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(301, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(109, 276);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introdusca la longitud a convertir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitud convertida";
            // 
            // grpDE
            // 
            this.grpDE.Controls.Add(this.listBox1);
            this.grpDE.Location = new System.Drawing.Point(12, 69);
            this.grpDE.Name = "grpDE";
            this.grpDE.Size = new System.Drawing.Size(224, 129);
            this.grpDE.TabIndex = 4;
            this.grpDE.TabStop = false;
            this.grpDE.Text = "De";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.listBox1.Location = new System.Drawing.Point(43, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // grpA
            // 
            this.grpA.Controls.Add(this.listBox2);
            this.grpA.Location = new System.Drawing.Point(265, 69);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(203, 129);
            this.grpA.TabIndex = 0;
            this.grpA.TabStop = false;
            this.grpA.Text = "a";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Pulgadas",
            "Pies",
            "Yardas"});
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(163, 95);
            this.listBox2.TabIndex = 0;
            // 
            // txtLongaConvert
            // 
            this.txtLongaConvert.Location = new System.Drawing.Point(271, 18);
            this.txtLongaConvert.Name = "txtLongaConvert";
            this.txtLongaConvert.Size = new System.Drawing.Size(100, 20);
            this.txtLongaConvert.TabIndex = 5;
            // 
            // txtLongConvert
            // 
            this.txtLongConvert.Location = new System.Drawing.Point(205, 227);
            this.txtLongConvert.Name = "txtLongConvert";
            this.txtLongConvert.Size = new System.Drawing.Size(100, 20);
            this.txtLongConvert.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 337);
            this.Controls.Add(this.txtLongConvert);
            this.Controls.Add(this.txtLongaConvert);
            this.Controls.Add(this.grpA);
            this.Controls.Add(this.grpDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form3";
            this.Text = "Form3";
            this.grpDE.ResumeLayout(false);
            this.grpA.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDE;
        private System.Windows.Forms.GroupBox grpA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox txtLongaConvert;
        private System.Windows.Forms.TextBox txtLongConvert;
    }
}