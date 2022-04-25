namespace CentralitaUI
{
    partial class Llamador
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
            this.txt_NroDestino = new System.Windows.Forms.TextBox();
            this.grp_Numeros = new System.Windows.Forms.GroupBox();
            this.btn_numeral = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_asterisco = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Llamar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txt_NroOrigen = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.cmb_Franja = new System.Windows.Forms.ComboBox();
            this.grp_Numeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_NroDestino
            // 
            this.txt_NroDestino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NroDestino.Location = new System.Drawing.Point(30, 20);
            this.txt_NroDestino.Name = "txt_NroDestino";
            this.txt_NroDestino.PlaceholderText = "Nro Destino";
            this.txt_NroDestino.ReadOnly = true;
            this.txt_NroDestino.Size = new System.Drawing.Size(404, 36);
            this.txt_NroDestino.TabIndex = 0;
            this.txt_NroDestino.TextChanged += new System.EventHandler(this.txt_NroDestino_TextChanged);
            // 
            // grp_Numeros
            // 
            this.grp_Numeros.Controls.Add(this.btn_numeral);
            this.grp_Numeros.Controls.Add(this.btn_0);
            this.grp_Numeros.Controls.Add(this.btn_asterisco);
            this.grp_Numeros.Controls.Add(this.btn_9);
            this.grp_Numeros.Controls.Add(this.btn_8);
            this.grp_Numeros.Controls.Add(this.btn_7);
            this.grp_Numeros.Controls.Add(this.btn_6);
            this.grp_Numeros.Controls.Add(this.btn_5);
            this.grp_Numeros.Controls.Add(this.btn_4);
            this.grp_Numeros.Controls.Add(this.btn_2);
            this.grp_Numeros.Controls.Add(this.btn_3);
            this.grp_Numeros.Controls.Add(this.btn_1);
            this.grp_Numeros.Location = new System.Drawing.Point(30, 62);
            this.grp_Numeros.Name = "grp_Numeros";
            this.grp_Numeros.Size = new System.Drawing.Size(157, 207);
            this.grp_Numeros.TabIndex = 1;
            this.grp_Numeros.TabStop = false;
            this.grp_Numeros.Text = "Panel";
            // 
            // btn_numeral
            // 
            this.btn_numeral.Location = new System.Drawing.Point(105, 157);
            this.btn_numeral.Name = "btn_numeral";
            this.btn_numeral.Size = new System.Drawing.Size(42, 39);
            this.btn_numeral.TabIndex = 11;
            this.btn_numeral.Text = "#";
            this.btn_numeral.UseVisualStyleBackColor = true;
            this.btn_numeral.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(57, 157);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(42, 39);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_asterisco
            // 
            this.btn_asterisco.Location = new System.Drawing.Point(9, 157);
            this.btn_asterisco.Name = "btn_asterisco";
            this.btn_asterisco.Size = new System.Drawing.Size(42, 39);
            this.btn_asterisco.TabIndex = 9;
            this.btn_asterisco.Text = "*";
            this.btn_asterisco.UseVisualStyleBackColor = true;
            this.btn_asterisco.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(105, 112);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(42, 39);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(57, 112);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(42, 39);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(9, 112);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(42, 39);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(105, 67);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(42, 39);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(57, 67);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(42, 39);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(9, 67);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(42, 39);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(57, 22);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(42, 39);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(105, 22);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(42, 39);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(9, 22);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(42, 39);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_Llamar
            // 
            this.btn_Llamar.Location = new System.Drawing.Point(212, 84);
            this.btn_Llamar.Name = "btn_Llamar";
            this.btn_Llamar.Size = new System.Drawing.Size(222, 39);
            this.btn_Llamar.TabIndex = 2;
            this.btn_Llamar.Text = "Llamar";
            this.btn_Llamar.UseVisualStyleBackColor = true;
            this.btn_Llamar.Click += new System.EventHandler(this.btn_Llamar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(212, 129);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(222, 39);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // txt_NroOrigen
            // 
            this.txt_NroOrigen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NroOrigen.Location = new System.Drawing.Point(212, 184);
            this.txt_NroOrigen.Name = "txt_NroOrigen";
            this.txt_NroOrigen.PlaceholderText = "Nro Origen";
            this.txt_NroOrigen.Size = new System.Drawing.Size(222, 29);
            this.txt_NroOrigen.TabIndex = 4;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(212, 230);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(222, 39);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // cmb_Franja
            // 
            this.cmb_Franja.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_Franja.FormattingEnabled = true;
            this.cmb_Franja.Location = new System.Drawing.Point(30, 290);
            this.cmb_Franja.Name = "cmb_Franja";
            this.cmb_Franja.Size = new System.Drawing.Size(404, 36);
            this.cmb_Franja.TabIndex = 6;
            this.cmb_Franja.Text = "Franja";
            // 
            // Llamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 345);
            this.Controls.Add(this.cmb_Franja);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_NroOrigen);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Llamar);
            this.Controls.Add(this.grp_Numeros);
            this.Controls.Add(this.txt_NroDestino);
            this.Name = "Llamador";
            this.Text = "Llamador";
            this.grp_Numeros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NroDestino;
        private System.Windows.Forms.GroupBox grp_Numeros;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_numeral;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_asterisco;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_Llamar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.TextBox txt_NroOrigen;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.ComboBox cmb_Franja;
    }
}