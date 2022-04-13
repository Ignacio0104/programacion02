namespace EjercicioC01_Unidad05Cotizador
{
    partial class frm_conversor
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
            this.lbl_Cotizacion = new System.Windows.Forms.Label();
            this.btn_candado = new System.Windows.Forms.Button();
            this.txt_euro = new System.Windows.Forms.TextBox();
            this.txt_dolar = new System.Windows.Forms.TextBox();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.txt_inputEuro = new System.Windows.Forms.TextBox();
            this.txt_inputDolar = new System.Windows.Forms.TextBox();
            this.txt_inputPeso = new System.Windows.Forms.TextBox();
            this.btn_cotizarEuro = new System.Windows.Forms.Button();
            this.btn_cotizarDolar = new System.Windows.Forms.Button();
            this.btn_cotizarPeso = new System.Windows.Forms.Button();
            this.lbl_EuroDos = new System.Windows.Forms.Label();
            this.lbl_dolarDos = new System.Windows.Forms.Label();
            this.lbl_pesoDos = new System.Windows.Forms.Label();
            this.txt_euroDesdeEuro = new System.Windows.Forms.TextBox();
            this.txt_dolarDesdeEuro = new System.Windows.Forms.TextBox();
            this.txt_pesoDesdeEuro = new System.Windows.Forms.TextBox();
            this.txt_euroDesdeDolar = new System.Windows.Forms.TextBox();
            this.txt_dolarDesdeDolar = new System.Windows.Forms.TextBox();
            this.txt_pesoDesdeDolar = new System.Windows.Forms.TextBox();
            this.txt_euroDesdePeso = new System.Windows.Forms.TextBox();
            this.txt_dolarDesdePeso = new System.Windows.Forms.TextBox();
            this.txt_pesoDesdePeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Cotizacion
            // 
            this.lbl_Cotizacion.AutoSize = true;
            this.lbl_Cotizacion.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Cotizacion.Location = new System.Drawing.Point(91, 14);
            this.lbl_Cotizacion.Name = "lbl_Cotizacion";
            this.lbl_Cotizacion.Size = new System.Drawing.Size(101, 25);
            this.lbl_Cotizacion.TabIndex = 0;
            this.lbl_Cotizacion.Text = "Cotizacion";
            // 
            // btn_candado
            // 
            this.btn_candado.Location = new System.Drawing.Point(213, 12);
            this.btn_candado.Name = "btn_candado";
            this.btn_candado.Size = new System.Drawing.Size(95, 30);
            this.btn_candado.TabIndex = 1;
            this.btn_candado.Text = "Bloquear";
            this.btn_candado.UseVisualStyleBackColor = true;
            this.btn_candado.Click += new System.EventHandler(this.btn_candado_Click);
            // 
            // txt_euro
            // 
            this.txt_euro.Location = new System.Drawing.Point(336, 15);
            this.txt_euro.Name = "txt_euro";
            this.txt_euro.Size = new System.Drawing.Size(100, 23);
            this.txt_euro.TabIndex = 2;
            this.txt_euro.Leave += new System.EventHandler(this.txt_euro_Leave);
            // 
            // txt_dolar
            // 
            this.txt_dolar.Location = new System.Drawing.Point(470, 15);
            this.txt_dolar.Name = "txt_dolar";
            this.txt_dolar.Size = new System.Drawing.Size(100, 23);
            this.txt_dolar.TabIndex = 3;
            this.txt_dolar.Leave += new System.EventHandler(this.txt_dolar_Leave);
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(605, 15);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(100, 23);
            this.txt_peso.TabIndex = 4;
            this.txt_peso.Leave += new System.EventHandler(this.txt_peso_Leave);
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_euro.Location = new System.Drawing.Point(12, 75);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(51, 25);
            this.lbl_euro.TabIndex = 5;
            this.lbl_euro.Text = "Euro";
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dolar.Location = new System.Drawing.Point(12, 127);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(58, 25);
            this.lbl_dolar.TabIndex = 6;
            this.lbl_dolar.Text = "Dolar";
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_peso.Location = new System.Drawing.Point(12, 181);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(51, 25);
            this.lbl_peso.TabIndex = 7;
            this.lbl_peso.Text = "Peso";
            // 
            // txt_inputEuro
            // 
            this.txt_inputEuro.Location = new System.Drawing.Point(92, 77);
            this.txt_inputEuro.Name = "txt_inputEuro";
            this.txt_inputEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_inputEuro.TabIndex = 8;
            // 
            // txt_inputDolar
            // 
            this.txt_inputDolar.Location = new System.Drawing.Point(92, 130);
            this.txt_inputDolar.Name = "txt_inputDolar";
            this.txt_inputDolar.Size = new System.Drawing.Size(100, 23);
            this.txt_inputDolar.TabIndex = 9;
            // 
            // txt_inputPeso
            // 
            this.txt_inputPeso.Location = new System.Drawing.Point(91, 184);
            this.txt_inputPeso.Name = "txt_inputPeso";
            this.txt_inputPeso.Size = new System.Drawing.Size(100, 23);
            this.txt_inputPeso.TabIndex = 10;
            // 
            // btn_cotizarEuro
            // 
            this.btn_cotizarEuro.Location = new System.Drawing.Point(213, 72);
            this.btn_cotizarEuro.Name = "btn_cotizarEuro";
            this.btn_cotizarEuro.Size = new System.Drawing.Size(95, 30);
            this.btn_cotizarEuro.TabIndex = 11;
            this.btn_cotizarEuro.Text = "->";
            this.btn_cotizarEuro.UseVisualStyleBackColor = true;
            this.btn_cotizarEuro.Click += new System.EventHandler(this.btn_cotizarEuro_Click);
            // 
            // btn_cotizarDolar
            // 
            this.btn_cotizarDolar.Location = new System.Drawing.Point(213, 127);
            this.btn_cotizarDolar.Name = "btn_cotizarDolar";
            this.btn_cotizarDolar.Size = new System.Drawing.Size(95, 30);
            this.btn_cotizarDolar.TabIndex = 12;
            this.btn_cotizarDolar.Text = "->";
            this.btn_cotizarDolar.UseVisualStyleBackColor = true;
            this.btn_cotizarDolar.Click += new System.EventHandler(this.btn_cotizarDolar_Click);
            // 
            // btn_cotizarPeso
            // 
            this.btn_cotizarPeso.Location = new System.Drawing.Point(213, 179);
            this.btn_cotizarPeso.Name = "btn_cotizarPeso";
            this.btn_cotizarPeso.Size = new System.Drawing.Size(95, 30);
            this.btn_cotizarPeso.TabIndex = 13;
            this.btn_cotizarPeso.Text = "->";
            this.btn_cotizarPeso.UseVisualStyleBackColor = true;
            this.btn_cotizarPeso.Click += new System.EventHandler(this.btn_cotizarPeso_Click);
            // 
            // lbl_EuroDos
            // 
            this.lbl_EuroDos.AutoSize = true;
            this.lbl_EuroDos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EuroDos.Location = new System.Drawing.Point(361, 41);
            this.lbl_EuroDos.Name = "lbl_EuroDos";
            this.lbl_EuroDos.Size = new System.Drawing.Size(51, 25);
            this.lbl_EuroDos.TabIndex = 14;
            this.lbl_EuroDos.Text = "Euro";
            // 
            // lbl_dolarDos
            // 
            this.lbl_dolarDos.AutoSize = true;
            this.lbl_dolarDos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dolarDos.Location = new System.Drawing.Point(490, 41);
            this.lbl_dolarDos.Name = "lbl_dolarDos";
            this.lbl_dolarDos.Size = new System.Drawing.Size(58, 25);
            this.lbl_dolarDos.TabIndex = 15;
            this.lbl_dolarDos.Text = "Dolar";
            // 
            // lbl_pesoDos
            // 
            this.lbl_pesoDos.AutoSize = true;
            this.lbl_pesoDos.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pesoDos.Location = new System.Drawing.Point(629, 41);
            this.lbl_pesoDos.Name = "lbl_pesoDos";
            this.lbl_pesoDos.Size = new System.Drawing.Size(51, 25);
            this.lbl_pesoDos.TabIndex = 16;
            this.lbl_pesoDos.Text = "Peso";
            // 
            // txt_euroDesdeEuro
            // 
            this.txt_euroDesdeEuro.Enabled = false;
            this.txt_euroDesdeEuro.Location = new System.Drawing.Point(336, 79);
            this.txt_euroDesdeEuro.Name = "txt_euroDesdeEuro";
            this.txt_euroDesdeEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_euroDesdeEuro.TabIndex = 17;
            // 
            // txt_dolarDesdeEuro
            // 
            this.txt_dolarDesdeEuro.Enabled = false;
            this.txt_dolarDesdeEuro.Location = new System.Drawing.Point(470, 79);
            this.txt_dolarDesdeEuro.Name = "txt_dolarDesdeEuro";
            this.txt_dolarDesdeEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_dolarDesdeEuro.TabIndex = 18;
            // 
            // txt_pesoDesdeEuro
            // 
            this.txt_pesoDesdeEuro.Enabled = false;
            this.txt_pesoDesdeEuro.Location = new System.Drawing.Point(605, 79);
            this.txt_pesoDesdeEuro.Name = "txt_pesoDesdeEuro";
            this.txt_pesoDesdeEuro.Size = new System.Drawing.Size(100, 23);
            this.txt_pesoDesdeEuro.TabIndex = 19;
            // 
            // txt_euroDesdeDolar
            // 
            this.txt_euroDesdeDolar.Enabled = false;
            this.txt_euroDesdeDolar.Location = new System.Drawing.Point(336, 130);
            this.txt_euroDesdeDolar.Name = "txt_euroDesdeDolar";
            this.txt_euroDesdeDolar.Size = new System.Drawing.Size(100, 23);
            this.txt_euroDesdeDolar.TabIndex = 20;
            // 
            // txt_dolarDesdeDolar
            // 
            this.txt_dolarDesdeDolar.Enabled = false;
            this.txt_dolarDesdeDolar.Location = new System.Drawing.Point(470, 130);
            this.txt_dolarDesdeDolar.Name = "txt_dolarDesdeDolar";
            this.txt_dolarDesdeDolar.Size = new System.Drawing.Size(100, 23);
            this.txt_dolarDesdeDolar.TabIndex = 21;
            // 
            // txt_pesoDesdeDolar
            // 
            this.txt_pesoDesdeDolar.Enabled = false;
            this.txt_pesoDesdeDolar.Location = new System.Drawing.Point(605, 130);
            this.txt_pesoDesdeDolar.Name = "txt_pesoDesdeDolar";
            this.txt_pesoDesdeDolar.Size = new System.Drawing.Size(100, 23);
            this.txt_pesoDesdeDolar.TabIndex = 22;
            // 
            // txt_euroDesdePeso
            // 
            this.txt_euroDesdePeso.Enabled = false;
            this.txt_euroDesdePeso.Location = new System.Drawing.Point(336, 184);
            this.txt_euroDesdePeso.Name = "txt_euroDesdePeso";
            this.txt_euroDesdePeso.Size = new System.Drawing.Size(100, 23);
            this.txt_euroDesdePeso.TabIndex = 23;
            // 
            // txt_dolarDesdePeso
            // 
            this.txt_dolarDesdePeso.Enabled = false;
            this.txt_dolarDesdePeso.Location = new System.Drawing.Point(470, 184);
            this.txt_dolarDesdePeso.Name = "txt_dolarDesdePeso";
            this.txt_dolarDesdePeso.Size = new System.Drawing.Size(100, 23);
            this.txt_dolarDesdePeso.TabIndex = 24;
            // 
            // txt_pesoDesdePeso
            // 
            this.txt_pesoDesdePeso.Enabled = false;
            this.txt_pesoDesdePeso.Location = new System.Drawing.Point(605, 184);
            this.txt_pesoDesdePeso.Name = "txt_pesoDesdePeso";
            this.txt_pesoDesdePeso.Size = new System.Drawing.Size(100, 23);
            this.txt_pesoDesdePeso.TabIndex = 25;
            // 
            // frm_conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 299);
            this.Controls.Add(this.txt_pesoDesdePeso);
            this.Controls.Add(this.txt_dolarDesdePeso);
            this.Controls.Add(this.txt_euroDesdePeso);
            this.Controls.Add(this.txt_pesoDesdeDolar);
            this.Controls.Add(this.txt_dolarDesdeDolar);
            this.Controls.Add(this.txt_euroDesdeDolar);
            this.Controls.Add(this.txt_pesoDesdeEuro);
            this.Controls.Add(this.txt_dolarDesdeEuro);
            this.Controls.Add(this.txt_euroDesdeEuro);
            this.Controls.Add(this.lbl_pesoDos);
            this.Controls.Add(this.lbl_dolarDos);
            this.Controls.Add(this.lbl_EuroDos);
            this.Controls.Add(this.btn_cotizarPeso);
            this.Controls.Add(this.btn_cotizarDolar);
            this.Controls.Add(this.btn_cotizarEuro);
            this.Controls.Add(this.txt_inputPeso);
            this.Controls.Add(this.txt_inputDolar);
            this.Controls.Add(this.txt_inputEuro);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_dolar);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_dolar);
            this.Controls.Add(this.txt_euro);
            this.Controls.Add(this.btn_candado);
            this.Controls.Add(this.lbl_Cotizacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(777, 338);
            this.MinimumSize = new System.Drawing.Size(777, 338);
            this.Name = "frm_conversor";
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.frm_conversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cotizacion;
        private System.Windows.Forms.Button btn_candado;
        private System.Windows.Forms.TextBox txt_euro;
        private System.Windows.Forms.TextBox txt_dolar;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox txt_inputEuro;
        private System.Windows.Forms.TextBox txt_inputDolar;
        private System.Windows.Forms.TextBox txt_inputPeso;
        private System.Windows.Forms.Button btn_cotizarEuro;
        private System.Windows.Forms.Button btn_cotizarDolar;
        private System.Windows.Forms.Button btn_cotizarPeso;
        private System.Windows.Forms.Label lbl_EuroDos;
        private System.Windows.Forms.Label lbl_dolarDos;
        private System.Windows.Forms.Label lbl_pesoDos;
        private System.Windows.Forms.TextBox txt_euroDesdeEuro;
        private System.Windows.Forms.TextBox txt_dolarDesdeEuro;
        private System.Windows.Forms.TextBox txt_pesoDesdeEuro;
        private System.Windows.Forms.TextBox txt_euroDesdeDolar;
        private System.Windows.Forms.TextBox txt_dolarDesdeDolar;
        private System.Windows.Forms.TextBox txt_pesoDesdeDolar;
        private System.Windows.Forms.TextBox txt_euroDesdePeso;
        private System.Windows.Forms.TextBox txt_dolarDesdePeso;
        private System.Windows.Forms.TextBox txt_pesoDesdePeso;
    }
}
