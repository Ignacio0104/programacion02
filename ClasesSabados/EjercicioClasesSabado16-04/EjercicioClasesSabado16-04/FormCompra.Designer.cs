namespace EjercicioClasesSabado16_04
{
    partial class FormCompra
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.numEntradas = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadEntradas = new System.Windows.Forms.Label();
            this.btn_FinalizarCompra = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(62, 40);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.PlaceholderText = "Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(312, 23);
            this.txt_Nombre.TabIndex = 0;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(62, 92);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.PlaceholderText = "Numero de telefono";
            this.txt_Telefono.ShortcutsEnabled = false;
            this.txt_Telefono.Size = new System.Drawing.Size(312, 23);
            this.txt_Telefono.TabIndex = 1;
            // 
            // txt_Dni
            // 
            this.txt_Dni.Location = new System.Drawing.Point(62, 143);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.PlaceholderText = "DNI";
            this.txt_Dni.ShortcutsEnabled = false;
            this.txt_Dni.Size = new System.Drawing.Size(312, 23);
            this.txt_Dni.TabIndex = 2;
            // 
            // numEntradas
            // 
            this.numEntradas.Location = new System.Drawing.Point(147, 204);
            this.numEntradas.Name = "numEntradas";
            this.numEntradas.Size = new System.Drawing.Size(120, 23);
            this.numEntradas.TabIndex = 3;
            // 
            // lblCantidadEntradas
            // 
            this.lblCantidadEntradas.AutoSize = true;
            this.lblCantidadEntradas.Location = new System.Drawing.Point(147, 186);
            this.lblCantidadEntradas.Name = "lblCantidadEntradas";
            this.lblCantidadEntradas.Size = new System.Drawing.Size(55, 15);
            this.lblCantidadEntradas.TabIndex = 4;
            this.lblCantidadEntradas.Text = "Cantidad";
            // 
            // btn_FinalizarCompra
            // 
            this.btn_FinalizarCompra.Location = new System.Drawing.Point(62, 256);
            this.btn_FinalizarCompra.Name = "btn_FinalizarCompra";
            this.btn_FinalizarCompra.Size = new System.Drawing.Size(205, 37);
            this.btn_FinalizarCompra.TabIndex = 5;
            this.btn_FinalizarCompra.Text = "Finalizar Compra";
            this.btn_FinalizarCompra.UseVisualStyleBackColor = true;
            this.btn_FinalizarCompra.Click += new System.EventHandler(this.btn_FinalizarCompra_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(307, 256);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(67, 37);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 331);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_FinalizarCompra);
            this.Controls.Add(this.lblCantidadEntradas);
            this.Controls.Add(this.numEntradas);
            this.Controls.Add(this.txt_Dni);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCompra";
            this.Text = "FormCompra";
            ((System.ComponentModel.ISupportInitialize)(this.numEntradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.NumericUpDown numEntradas;
        private System.Windows.Forms.Label lblCantidadEntradas;
        private System.Windows.Forms.Button btn_FinalizarCompra;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}