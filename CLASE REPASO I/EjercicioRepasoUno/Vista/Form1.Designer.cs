namespace Vista
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
            this.btn_Validar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Validar
            // 
            this.btn_Validar.Location = new System.Drawing.Point(401, 136);
            this.btn_Validar.Name = "btn_Validar";
            this.btn_Validar.Size = new System.Drawing.Size(213, 62);
            this.btn_Validar.TabIndex = 0;
            this.btn_Validar.Text = "Validar Stock";
            this.btn_Validar.UseVisualStyleBackColor = true;
            this.btn_Validar.Click += new System.EventHandler(this.btn_Validar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Validar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Validar;
    }
}
