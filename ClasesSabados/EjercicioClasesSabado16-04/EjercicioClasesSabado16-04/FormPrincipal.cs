using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace EjercicioClasesSabado16_04
{
    public partial class frm_Principal : Form
    {
        Espectador[] listaEspectadores;
        public frm_Principal()
        {
            InitializeComponent();
            listaEspectadores = new Espectador[20];
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            FormCompra formularioCompra = new FormCompra();
            DialogResult resultado = formularioCompra.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lstVentas.Items.Add(formularioCompra.Espectador.Mostrar());

            }
        }

    }
}
