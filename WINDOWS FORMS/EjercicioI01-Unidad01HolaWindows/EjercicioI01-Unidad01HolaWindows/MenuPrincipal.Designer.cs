namespace EjercicioI01_Unidad01HolaWindows
{
    partial class MenuPrincipal
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.box_materias = new System.Windows.Forms.ComboBox();
            this.lbl_materiaFavorita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(22, 57);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(187, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(304, 57);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.PlaceholderText = "Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(187, 23);
            this.txt_Apellido.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(22, 23);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(89, 28);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(304, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // btn_saludar
            // 
            this.btn_saludar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_saludar.Location = new System.Drawing.Point(147, 95);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(207, 23);
            this.btn_saludar.TabIndex = 4;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // box_materias
            // 
            this.box_materias.FormattingEnabled = true;
            this.box_materias.Location = new System.Drawing.Point(22, 197);
            this.box_materias.Name = "box_materias";
            this.box_materias.Size = new System.Drawing.Size(456, 23);
            this.box_materias.TabIndex = 5;
            // 
            // lbl_materiaFavorita
            // 
            this.lbl_materiaFavorita.AutoSize = true;
            this.lbl_materiaFavorita.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materiaFavorita.Location = new System.Drawing.Point(22, 155);
            this.lbl_materiaFavorita.Name = "lbl_materiaFavorita";
            this.lbl_materiaFavorita.Size = new System.Drawing.Size(168, 28);
            this.lbl_materiaFavorita.TabIndex = 6;
            this.lbl_materiaFavorita.Text = "Materia Favorita";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 275);
            this.Controls.Add(this.lbl_materiaFavorita);
            this.Controls.Add(this.box_materias);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_Apellido);
            this.Controls.Add(this.txt_Nombre);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.ComboBox box_materias;
        private System.Windows.Forms.Label lbl_materiaFavorita;
    }
}
