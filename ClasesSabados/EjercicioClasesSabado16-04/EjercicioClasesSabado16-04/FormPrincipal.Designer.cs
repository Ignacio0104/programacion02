namespace EjercicioClasesSabado16_04
{
    partial class frm_Principal
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
            this.lbl_cantidadVentas = new System.Windows.Forms.Label();
            this.lbl_EntradasRestantes = new System.Windows.Forms.Label();
            this.lbl_NumeroEntradas = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_cantidadVentas
            // 
            this.lbl_cantidadVentas.AutoSize = true;
            this.lbl_cantidadVentas.Location = new System.Drawing.Point(42, 40);
            this.lbl_cantidadVentas.Name = "lbl_cantidadVentas";
            this.lbl_cantidadVentas.Size = new System.Drawing.Size(54, 15);
            this.lbl_cantidadVentas.TabIndex = 0;
            this.lbl_cantidadVentas.Text = "VENTAS: ";
            // 
            // lbl_EntradasRestantes
            // 
            this.lbl_EntradasRestantes.AutoSize = true;
            this.lbl_EntradasRestantes.Location = new System.Drawing.Point(377, 119);
            this.lbl_EntradasRestantes.Name = "lbl_EntradasRestantes";
            this.lbl_EntradasRestantes.Size = new System.Drawing.Size(105, 15);
            this.lbl_EntradasRestantes.TabIndex = 2;
            this.lbl_EntradasRestantes.Text = "Entradas restantes:";
            // 
            // lbl_NumeroEntradas
            // 
            this.lbl_NumeroEntradas.AutoSize = true;
            this.lbl_NumeroEntradas.Location = new System.Drawing.Point(377, 157);
            this.lbl_NumeroEntradas.Name = "lbl_NumeroEntradas";
            this.lbl_NumeroEntradas.Size = new System.Drawing.Size(19, 15);
            this.lbl_NumeroEntradas.TabIndex = 3;
            this.lbl_NumeroEntradas.Text = "15";
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(377, 327);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(127, 43);
            this.btn_Comprar.TabIndex = 4;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // lstVentas
            // 
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 15;
            this.lstVentas.Location = new System.Drawing.Point(42, 81);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(278, 289);
            this.lstVentas.TabIndex = 1;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 408);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.lbl_NumeroEntradas);
            this.Controls.Add(this.lbl_EntradasRestantes);
            this.Controls.Add(this.lstVentas);
            this.Controls.Add(this.lbl_cantidadVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticketek ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidadVentas;
        private System.Windows.Forms.Label lbl_EntradasRestantes;
        private System.Windows.Forms.Label lbl_NumeroEntradas;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.ListBox lstVentas;
    }
}
