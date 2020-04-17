namespace form3
{
    partial class form3
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
            this.lstDado = new System.Windows.Forms.ListBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDado
            // 
            this.lstDado.FormattingEnabled = true;
            this.lstDado.ItemHeight = 16;
            this.lstDado.Location = new System.Drawing.Point(14, 12);
            this.lstDado.Name = "lstDado";
            this.lstDado.Size = new System.Drawing.Size(120, 244);
            this.lstDado.TabIndex = 0;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(37, 280);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(75, 23);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 338);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.lstDado);
            this.Name = "ejercicio3";
            this.Text = "ejercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDado;
        private System.Windows.Forms.Button btnLanzar;
    }
}