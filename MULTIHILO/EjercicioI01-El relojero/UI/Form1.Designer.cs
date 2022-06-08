namespace UI
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnIniciarReloj = new System.Windows.Forms.Button();
            this.btnDetenerReloj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(29, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(858, 398);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(29, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label1";
            // 
            // btnIniciarReloj
            // 
            this.btnIniciarReloj.Location = new System.Drawing.Point(610, 9);
            this.btnIniciarReloj.Name = "btnIniciarReloj";
            this.btnIniciarReloj.Size = new System.Drawing.Size(132, 23);
            this.btnIniciarReloj.TabIndex = 2;
            this.btnIniciarReloj.Text = "Iniciar Reloj";
            this.btnIniciarReloj.UseVisualStyleBackColor = true;
            this.btnIniciarReloj.Click += new System.EventHandler(this.btnIniciarReloj_Click);
            // 
            // btnDetenerReloj
            // 
            this.btnDetenerReloj.Location = new System.Drawing.Point(755, 9);
            this.btnDetenerReloj.Name = "btnDetenerReloj";
            this.btnDetenerReloj.Size = new System.Drawing.Size(132, 23);
            this.btnDetenerReloj.TabIndex = 3;
            this.btnDetenerReloj.Text = "Detener Reloj";
            this.btnDetenerReloj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 487);
            this.Controls.Add(this.btnDetenerReloj);
            this.Controls.Add(this.btnIniciarReloj);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnIniciarReloj;
        private System.Windows.Forms.Button btnDetenerReloj;
    }
}
