namespace prac4
{
    partial class Form2
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
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgg = new System.Windows.Forms.Button();
            this.lstAgregado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número";
            // 
            // txtAgregar
            // 
            this.txtAgregar.Location = new System.Drawing.Point(95, 28);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(100, 20);
            this.txtAgregar.TabIndex = 2;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(242, 219);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(255, 245);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgg
            // 
            this.btnAgg.Location = new System.Drawing.Point(242, 25);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(75, 23);
            this.btnAgg.TabIndex = 5;
            this.btnAgg.Text = "Agregar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // lstAgregado
            // 
            this.lstAgregado.FormattingEnabled = true;
            this.lstAgregado.Location = new System.Drawing.Point(40, 66);
            this.lstAgregado.Name = "lstAgregado";
            this.lstAgregado.Size = new System.Drawing.Size(139, 212);
            this.lstAgregado.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 290);
            this.Controls.Add(this.lstAgregado);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.ListBox lstAgregado;
    }
}