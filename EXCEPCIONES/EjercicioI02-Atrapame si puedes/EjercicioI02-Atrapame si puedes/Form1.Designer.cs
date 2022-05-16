namespace EjercicioI02_Atrapame_si_puedes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtLibros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(26, 63);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.PlaceholderText = "Kilometro";
            this.txtKilometros.Size = new System.Drawing.Size(178, 23);
            this.txtKilometros.TabIndex = 0;
            // 
            // txtLibros
            // 
            this.txtLibros.Location = new System.Drawing.Point(26, 115);
            this.txtLibros.Name = "txtLibros";
            this.txtLibros.PlaceholderText = "Litros";
            this.txtLibros.Size = new System.Drawing.Size(178, 23);
            this.txtLibros.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(245, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(212, 161);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 240);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLibros);
            this.Controls.Add(this.txtKilometros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtLibros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
