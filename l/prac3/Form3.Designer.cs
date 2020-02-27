namespace prac3
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
            this.lstLanza = new System.Windows.Forms.ListBox();
            this.btnlanzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLanza
            // 
            this.lstLanza.FormattingEnabled = true;
            this.lstLanza.Location = new System.Drawing.Point(78, 12);
            this.lstLanza.Name = "lstLanza";
            this.lstLanza.Size = new System.Drawing.Size(120, 212);
            this.lstLanza.TabIndex = 0;
            // 
            // btnlanzar
            // 
            this.btnlanzar.Location = new System.Drawing.Point(98, 282);
            this.btnlanzar.Name = "btnlanzar";
            this.btnlanzar.Size = new System.Drawing.Size(75, 23);
            this.btnlanzar.TabIndex = 1;
            this.btnlanzar.Text = "Lanzar";
            this.btnlanzar.UseVisualStyleBackColor = true;
            this.btnlanzar.Click += new System.EventHandler(this.btnlanzar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 372);
            this.Controls.Add(this.btnlanzar);
            this.Controls.Add(this.lstLanza);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLanza;
        private System.Windows.Forms.Button btnlanzar;
    }
}