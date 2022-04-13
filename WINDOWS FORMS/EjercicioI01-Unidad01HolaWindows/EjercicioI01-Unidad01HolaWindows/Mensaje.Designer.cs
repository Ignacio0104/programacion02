namespace EjercicioI01_Unidad01HolaWindows
{
    partial class Mensaje
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
            this.lbl_mensajePrincipal = new System.Windows.Forms.Label();
            this.lbl_mensajeSecundario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_mensajePrincipal
            // 
            this.lbl_mensajePrincipal.AutoSize = true;
            this.lbl_mensajePrincipal.Font = new System.Drawing.Font("Segoe UI", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajePrincipal.Location = new System.Drawing.Point(43, 23);
            this.lbl_mensajePrincipal.Name = "lbl_mensajePrincipal";
            this.lbl_mensajePrincipal.Size = new System.Drawing.Size(411, 46);
            this.lbl_mensajePrincipal.TabIndex = 0;
            this.lbl_mensajePrincipal.Text = "! Hola, Windows Forms !";
            // 
            // lbl_mensajeSecundario
            // 
            this.lbl_mensajeSecundario.AutoSize = true;
            this.lbl_mensajeSecundario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mensajeSecundario.Location = new System.Drawing.Point(43, 103);
            this.lbl_mensajeSecundario.Name = "lbl_mensajeSecundario";
            this.lbl_mensajeSecundario.Size = new System.Drawing.Size(65, 28);
            this.lbl_mensajeSecundario.TabIndex = 1;
            this.lbl_mensajeSecundario.Text = "label1";
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 241);
            this.Controls.Add(this.lbl_mensajeSecundario);
            this.Controls.Add(this.lbl_mensajePrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 280);
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mensaje_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mensajePrincipal;
        private System.Windows.Forms.Label lbl_mensajeSecundario;
    }
}