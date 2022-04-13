namespace EjercicioI02_Unidad05Registro
{
    partial class frm_registro
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
            this.grpBox_Detalles = new System.Windows.Forms.GroupBox();
            this.num_edad = new System.Windows.Forms.NumericUpDown();
            this.ldl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.grp_genero = new System.Windows.Forms.GroupBox();
            this.radio3_genero = new System.Windows.Forms.RadioButton();
            this.radio2_genero = new System.Windows.Forms.RadioButton();
            this.radio1_genero = new System.Windows.Forms.RadioButton();
            this.grp_cursos = new System.Windows.Forms.GroupBox();
            this.check3_cursos = new System.Windows.Forms.CheckBox();
            this.check2_cursos = new System.Windows.Forms.CheckBox();
            this.check1_cursos = new System.Windows.Forms.CheckBox();
            this.lbox_pais = new System.Windows.Forms.ListBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.grpBox_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).BeginInit();
            this.grp_genero.SuspendLayout();
            this.grp_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_Detalles
            // 
            this.grpBox_Detalles.Controls.Add(this.num_edad);
            this.grpBox_Detalles.Controls.Add(this.ldl_edad);
            this.grpBox_Detalles.Controls.Add(this.lbl_direccion);
            this.grpBox_Detalles.Controls.Add(this.lbl_nombre);
            this.grpBox_Detalles.Controls.Add(this.txt_direccion);
            this.grpBox_Detalles.Controls.Add(this.txt_nombre);
            this.grpBox_Detalles.Location = new System.Drawing.Point(30, 22);
            this.grpBox_Detalles.Name = "grpBox_Detalles";
            this.grpBox_Detalles.Size = new System.Drawing.Size(230, 188);
            this.grpBox_Detalles.TabIndex = 0;
            this.grpBox_Detalles.TabStop = false;
            this.grpBox_Detalles.Text = "Detalles del usuario";
            // 
            // num_edad
            // 
            this.num_edad.Location = new System.Drawing.Point(104, 131);
            this.num_edad.Name = "num_edad";
            this.num_edad.Size = new System.Drawing.Size(113, 23);
            this.num_edad.TabIndex = 5;
            // 
            // ldl_edad
            // 
            this.ldl_edad.AutoSize = true;
            this.ldl_edad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ldl_edad.Location = new System.Drawing.Point(6, 133);
            this.ldl_edad.Name = "ldl_edad";
            this.ldl_edad.Size = new System.Drawing.Size(44, 21);
            this.ldl_edad.TabIndex = 4;
            this.ldl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_direccion.Location = new System.Drawing.Point(6, 84);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(75, 21);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(6, 45);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(68, 21);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(104, 86);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(109, 23);
            this.txt_direccion.TabIndex = 1;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(104, 43);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(109, 23);
            this.txt_nombre.TabIndex = 0;
            // 
            // grp_genero
            // 
            this.grp_genero.Controls.Add(this.radio3_genero);
            this.grp_genero.Controls.Add(this.radio2_genero);
            this.grp_genero.Controls.Add(this.radio1_genero);
            this.grp_genero.Location = new System.Drawing.Point(318, 22);
            this.grp_genero.Name = "grp_genero";
            this.grp_genero.Size = new System.Drawing.Size(165, 137);
            this.grp_genero.TabIndex = 1;
            this.grp_genero.TabStop = false;
            this.grp_genero.Text = "Genero";
            // 
            // radio3_genero
            // 
            this.radio3_genero.AutoSize = true;
            this.radio3_genero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio3_genero.Location = new System.Drawing.Point(23, 86);
            this.radio3_genero.Name = "radio3_genero";
            this.radio3_genero.Size = new System.Drawing.Size(102, 25);
            this.radio3_genero.TabIndex = 2;
            this.radio3_genero.TabStop = true;
            this.radio3_genero.Text = "No binario";
            this.radio3_genero.UseVisualStyleBackColor = true;
            // 
            // radio2_genero
            // 
            this.radio2_genero.AutoSize = true;
            this.radio2_genero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio2_genero.Location = new System.Drawing.Point(23, 53);
            this.radio2_genero.Name = "radio2_genero";
            this.radio2_genero.Size = new System.Drawing.Size(97, 25);
            this.radio2_genero.TabIndex = 1;
            this.radio2_genero.TabStop = true;
            this.radio2_genero.Text = "Femenino";
            this.radio2_genero.UseVisualStyleBackColor = true;
            // 
            // radio1_genero
            // 
            this.radio1_genero.AutoSize = true;
            this.radio1_genero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radio1_genero.Location = new System.Drawing.Point(23, 22);
            this.radio1_genero.Name = "radio1_genero";
            this.radio1_genero.Size = new System.Drawing.Size(99, 25);
            this.radio1_genero.TabIndex = 0;
            this.radio1_genero.TabStop = true;
            this.radio1_genero.Text = "Masculino";
            this.radio1_genero.UseVisualStyleBackColor = true;
            // 
            // grp_cursos
            // 
            this.grp_cursos.Controls.Add(this.check3_cursos);
            this.grp_cursos.Controls.Add(this.check2_cursos);
            this.grp_cursos.Controls.Add(this.check1_cursos);
            this.grp_cursos.Location = new System.Drawing.Point(318, 170);
            this.grp_cursos.Name = "grp_cursos";
            this.grp_cursos.Size = new System.Drawing.Size(166, 116);
            this.grp_cursos.TabIndex = 2;
            this.grp_cursos.TabStop = false;
            this.grp_cursos.Text = "Cursos";
            // 
            // check3_cursos
            // 
            this.check3_cursos.AutoSize = true;
            this.check3_cursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check3_cursos.Location = new System.Drawing.Point(23, 72);
            this.check3_cursos.Name = "check3_cursos";
            this.check3_cursos.Size = new System.Drawing.Size(99, 25);
            this.check3_cursos.TabIndex = 2;
            this.check3_cursos.Text = "JavaScript";
            this.check3_cursos.UseVisualStyleBackColor = true;
            // 
            // check2_cursos
            // 
            this.check2_cursos.AutoSize = true;
            this.check2_cursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check2_cursos.Location = new System.Drawing.Point(23, 47);
            this.check2_cursos.Name = "check2_cursos";
            this.check2_cursos.Size = new System.Drawing.Size(61, 25);
            this.check2_cursos.TabIndex = 1;
            this.check2_cursos.Text = "C++";
            this.check2_cursos.UseVisualStyleBackColor = true;
            // 
            // check1_cursos
            // 
            this.check1_cursos.AutoSize = true;
            this.check1_cursos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check1_cursos.Location = new System.Drawing.Point(23, 22);
            this.check1_cursos.Name = "check1_cursos";
            this.check1_cursos.Size = new System.Drawing.Size(48, 25);
            this.check1_cursos.TabIndex = 0;
            this.check1_cursos.Text = "C#";
            this.check1_cursos.UseVisualStyleBackColor = true;
            // 
            // lbox_pais
            // 
            this.lbox_pais.FormattingEnabled = true;
            this.lbox_pais.ItemHeight = 15;
            this.lbox_pais.Location = new System.Drawing.Point(30, 242);
            this.lbox_pais.Name = "lbox_pais";
            this.lbox_pais.Size = new System.Drawing.Size(231, 94);
            this.lbox_pais.TabIndex = 3;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_pais.Location = new System.Drawing.Point(29, 217);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(37, 21);
            this.lbl_pais.TabIndex = 4;
            this.lbl_pais.Text = "Pais";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ingresar.Location = new System.Drawing.Point(318, 302);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(166, 46);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // frm_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.lbox_pais);
            this.Controls.Add(this.grp_cursos);
            this.Controls.Add(this.grp_genero);
            this.Controls.Add(this.grpBox_Detalles);
            this.MaximumSize = new System.Drawing.Size(555, 489);
            this.MinimumSize = new System.Drawing.Size(555, 489);
            this.Name = "frm_registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frm_registro_Load);
            this.grpBox_Detalles.ResumeLayout(false);
            this.grpBox_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_edad)).EndInit();
            this.grp_genero.ResumeLayout(false);
            this.grp_genero.PerformLayout();
            this.grp_cursos.ResumeLayout(false);
            this.grp_cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_Detalles;
        private System.Windows.Forms.NumericUpDown num_edad;
        private System.Windows.Forms.Label ldl_edad;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.GroupBox grp_genero;
        private System.Windows.Forms.RadioButton radio3_genero;
        private System.Windows.Forms.RadioButton radio2_genero;
        private System.Windows.Forms.RadioButton radio1_genero;
        private System.Windows.Forms.GroupBox grp_cursos;
        private System.Windows.Forms.CheckBox check1_cursos;
        private System.Windows.Forms.CheckBox check3_cursos;
        private System.Windows.Forms.CheckBox check2_cursos;
        private System.Windows.Forms.ListBox lbox_pais;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Button btn_ingresar;
    }
}
