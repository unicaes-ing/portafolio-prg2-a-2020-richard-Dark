namespace prac_2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.rdoDesc1 = new System.Windows.Forms.RadioButton();
            this.rdoDesc2 = new System.Windows.Forms.RadioButton();
            this.rdoDesc3 = new System.Windows.Forms.RadioButton();
            this.rdoDesc4 = new System.Windows.Forms.RadioButton();
            this.rdoDesc5 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Descuento = new System.Windows.Forms.GroupBox();
            this.Descuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descuento ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(80, 28);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(80, 62);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(80, 144);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(100, 20);
            this.txtdescuento.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(80, 179);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 7;
            // 
            // rdoDesc1
            // 
            this.rdoDesc1.AutoSize = true;
            this.rdoDesc1.Location = new System.Drawing.Point(47, 19);
            this.rdoDesc1.Name = "rdoDesc1";
            this.rdoDesc1.Size = new System.Drawing.Size(39, 17);
            this.rdoDesc1.TabIndex = 8;
            this.rdoDesc1.TabStop = true;
            this.rdoDesc1.Text = "0%";
            this.rdoDesc1.UseVisualStyleBackColor = true;
            // 
            // rdoDesc2
            // 
            this.rdoDesc2.AutoSize = true;
            this.rdoDesc2.Location = new System.Drawing.Point(47, 42);
            this.rdoDesc2.Name = "rdoDesc2";
            this.rdoDesc2.Size = new System.Drawing.Size(39, 17);
            this.rdoDesc2.TabIndex = 9;
            this.rdoDesc2.TabStop = true;
            this.rdoDesc2.Text = "5%";
            this.rdoDesc2.UseVisualStyleBackColor = true;
            // 
            // rdoDesc3
            // 
            this.rdoDesc3.AutoSize = true;
            this.rdoDesc3.Location = new System.Drawing.Point(47, 65);
            this.rdoDesc3.Name = "rdoDesc3";
            this.rdoDesc3.Size = new System.Drawing.Size(45, 17);
            this.rdoDesc3.TabIndex = 10;
            this.rdoDesc3.TabStop = true;
            this.rdoDesc3.Text = "10%";
            this.rdoDesc3.UseVisualStyleBackColor = true;
            // 
            // rdoDesc4
            // 
            this.rdoDesc4.AutoSize = true;
            this.rdoDesc4.Location = new System.Drawing.Point(47, 88);
            this.rdoDesc4.Name = "rdoDesc4";
            this.rdoDesc4.Size = new System.Drawing.Size(45, 17);
            this.rdoDesc4.TabIndex = 11;
            this.rdoDesc4.TabStop = true;
            this.rdoDesc4.Text = "15%";
            this.rdoDesc4.UseVisualStyleBackColor = true;
            // 
            // rdoDesc5
            // 
            this.rdoDesc5.AutoSize = true;
            this.rdoDesc5.Location = new System.Drawing.Point(47, 108);
            this.rdoDesc5.Name = "rdoDesc5";
            this.rdoDesc5.Size = new System.Drawing.Size(45, 17);
            this.rdoDesc5.TabIndex = 12;
            this.rdoDesc5.TabStop = true;
            this.rdoDesc5.Text = "20%";
            this.rdoDesc5.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(57, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(80, 226);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(188, 226);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Descuento
            // 
            this.Descuento.Controls.Add(this.rdoDesc1);
            this.Descuento.Controls.Add(this.rdoDesc2);
            this.Descuento.Controls.Add(this.rdoDesc3);
            this.Descuento.Controls.Add(this.rdoDesc4);
            this.Descuento.Controls.Add(this.rdoDesc5);
            this.Descuento.Location = new System.Drawing.Point(205, 42);
            this.Descuento.Name = "Descuento";
            this.Descuento.Size = new System.Drawing.Size(159, 131);
            this.Descuento.TabIndex = 17;
            this.Descuento.TabStop = false;
            this.Descuento.Text = "Descuento ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.Descuento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Descuento.ResumeLayout(false);
            this.Descuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.RadioButton rdoDesc1;
        private System.Windows.Forms.RadioButton rdoDesc2;
        private System.Windows.Forms.RadioButton rdoDesc3;
        private System.Windows.Forms.RadioButton rdoDesc4;
        private System.Windows.Forms.RadioButton rdoDesc5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox Descuento;
    }
}