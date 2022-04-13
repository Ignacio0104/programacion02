using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace EjercicioC01_Unidad05Cotizador
{
    public partial class frm_conversor : Form
    {
        private bool candado = false;
        public frm_conversor()
        {
            InitializeComponent();
        }
        private void frm_conversor_Load(object sender, EventArgs e)
        {
            txt_dolar.Text = "1";
            txt_euro.Text = Euro.GetCotizacion().ToString();
            txt_peso.Text = Peso.GetCotizacion().ToString();
        }

        private void btn_candado_Click(object sender, EventArgs e)
        {
            this.candado = !this.candado;

            if (candado)
            {
                btn_candado.Text = "Desbloquear";
                txt_dolar.Enabled = false;
                txt_euro.Enabled = false;
                txt_peso.Enabled = false;
            }
            else
            {
                btn_candado.Text = "Bloquear";
                txt_dolar.Enabled = true;
                txt_euro.Enabled = true;
                txt_peso.Enabled = true;
            }
        }

        private void txt_dolar_Leave(object sender, EventArgs e)
        {
            txt_dolar.Text = "1";
        }

        private void txt_euro_Leave(object sender, EventArgs e)
        {
            Euro.SetCotizacion(txt_euro.Text);
        }

        private void txt_peso_Leave(object sender, EventArgs e)
        {
            Peso.SetCotizacion(txt_euro.Text);
        }

        private void btn_cotizarEuro_Click(object sender, EventArgs e)
        {
            double inputEuro;
            double.TryParse(txt_inputEuro.Text, out inputEuro);
            Euro euroIngresado= new Euro(inputEuro);
            Dolar dolarCotizado = (Dolar)euroIngresado;
            Peso pesoCotizado = (Peso)euroIngresado;


            txt_euroDesdeEuro.Text = txt_inputEuro.Text;
            txt_dolarDesdeEuro.Text = dolarCotizado.GetCantidad().ToString();
            txt_pesoDesdeEuro.Text = pesoCotizado.GetCantidad().ToString();
        }

        private void btn_cotizarDolar_Click(object sender, EventArgs e)
        {
            double inputDolar;
            double.TryParse(txt_inputDolar.Text, out inputDolar);
            Dolar dolarIngresado = new Dolar(inputDolar);
            Euro euroCotizado = (Euro)dolarIngresado;
            Peso pesoCotizado = (Peso)dolarIngresado;


            txt_euroDesdeDolar.Text = euroCotizado.GetCantidad().ToString();
            txt_dolarDesdeDolar.Text = txt_inputDolar.Text;
            txt_pesoDesdeDolar.Text = pesoCotizado.GetCantidad().ToString();
        }

        private void btn_cotizarPeso_Click(object sender, EventArgs e)
        {
            double inputPeso;
            double.TryParse(txt_inputPeso.Text, out inputPeso);
            Peso pesoIngresado = new Peso(inputPeso);
            Euro euroCotizado = (Euro)pesoIngresado;
            Dolar dolarCotizado = (Dolar)pesoIngresado;


            txt_euroDesdePeso.Text = euroCotizado.GetCantidad().ToString();
            txt_dolarDesdePeso.Text = dolarCotizado.GetCantidad().ToString();
            txt_pesoDesdePeso.Text = txt_inputPeso.Text;
        }
    }
}
