namespace UI
{
    partial class SimuladorForm
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
            this.lblPoblacion = new System.Windows.Forms.Label();
            this.lblMicroorganismo = new System.Windows.Forms.Label();
            this.txtPoblacion = new System.Windows.Forms.TextBox();
            this.cmbMicroorganismo = new System.Windows.Forms.ComboBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.richEvolucion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblPoblacion
            // 
            this.lblPoblacion.AutoSize = true;
            this.lblPoblacion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPoblacion.Location = new System.Drawing.Point(22, 24);
            this.lblPoblacion.Name = "lblPoblacion";
            this.lblPoblacion.Size = new System.Drawing.Size(164, 25);
            this.lblPoblacion.TabIndex = 0;
            this.lblPoblacion.Text = "Población a evaluar";
            // 
            // lblMicroorganismo
            // 
            this.lblMicroorganismo.AutoSize = true;
            this.lblMicroorganismo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMicroorganismo.Location = new System.Drawing.Point(22, 70);
            this.lblMicroorganismo.Name = "lblMicroorganismo";
            this.lblMicroorganismo.Size = new System.Drawing.Size(143, 25);
            this.lblMicroorganismo.TabIndex = 1;
            this.lblMicroorganismo.Text = "Microorganismo";
            // 
            // txtPoblacion
            // 
            this.txtPoblacion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoblacion.Location = new System.Drawing.Point(207, 24);
            this.txtPoblacion.Name = "txtPoblacion";
            this.txtPoblacion.Size = new System.Drawing.Size(170, 31);
            this.txtPoblacion.TabIndex = 2;
            // 
            // cmbMicroorganismo
            // 
            this.cmbMicroorganismo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMicroorganismo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbMicroorganismo.FormattingEnabled = true;
            this.cmbMicroorganismo.Location = new System.Drawing.Point(207, 67);
            this.cmbMicroorganismo.Name = "cmbMicroorganismo";
            this.cmbMicroorganismo.Size = new System.Drawing.Size(170, 31);
            this.cmbMicroorganismo.TabIndex = 3;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(558, 126);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(230, 44);
            this.btnEjecutar.TabIndex = 4;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // richEvolucion
            // 
            this.richEvolucion.Location = new System.Drawing.Point(0, 176);
            this.richEvolucion.Name = "richEvolucion";
            this.richEvolucion.Size = new System.Drawing.Size(801, 316);
            this.richEvolucion.TabIndex = 5;
            this.richEvolucion.Text = "";
            // 
            // SimuladorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.richEvolucion);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.cmbMicroorganismo);
            this.Controls.Add(this.txtPoblacion);
            this.Controls.Add(this.lblMicroorganismo);
            this.Controls.Add(this.lblPoblacion);
            this.Name = "SimuladorForm";
            this.Text = "Simulador de Pandemia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPoblacion;
        private System.Windows.Forms.Label lblMicroorganismo;
        private System.Windows.Forms.TextBox txtPoblacion;
        private System.Windows.Forms.ComboBox cmbMicroorganismo;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.RichTextBox richEvolucion;
    }
}
