namespace EjercicioBibliotecaUniversidad
{
    partial class MenuPrincipal
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.btnErroresAlumnos = new System.Windows.Forms.Button();
            this.btnErroresProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(82, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(161, 37);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(216, 173);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(293, 68);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(216, 173);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(12, 50);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(55, 15);
            this.lblAlumnos.TabIndex = 3;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(293, 50);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(62, 15);
            this.lblProfesor.TabIndex = 4;
            this.lblProfesor.Text = "Profesores";
            // 
            // btnErroresAlumnos
            // 
            this.btnErroresAlumnos.Location = new System.Drawing.Point(12, 253);
            this.btnErroresAlumnos.Name = "btnErroresAlumnos";
            this.btnErroresAlumnos.Size = new System.Drawing.Size(127, 23);
            this.btnErroresAlumnos.TabIndex = 5;
            this.btnErroresAlumnos.Text = "Errores Alumnos";
            this.btnErroresAlumnos.UseVisualStyleBackColor = true;
            this.btnErroresAlumnos.Click += new System.EventHandler(this.btnErroresAlumnos_Click);
            // 
            // btnErroresProfesores
            // 
            this.btnErroresProfesores.Location = new System.Drawing.Point(293, 253);
            this.btnErroresProfesores.Name = "btnErroresProfesores";
            this.btnErroresProfesores.Size = new System.Drawing.Size(136, 23);
            this.btnErroresProfesores.TabIndex = 6;
            this.btnErroresProfesores.Text = "Errores Profesores";
            this.btnErroresProfesores.UseVisualStyleBackColor = true;
            this.btnErroresProfesores.Click += new System.EventHandler(this.btnErroresProfesores_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 288);
            this.Controls.Add(this.btnErroresProfesores);
            this.Controls.Add(this.btnErroresAlumnos);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Button btnErroresAlumnos;
        private System.Windows.Forms.Button btnErroresProfesores;
    }
}