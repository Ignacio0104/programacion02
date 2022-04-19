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
    public partial class FormCompra : Form
    {
        private Espectador espectadorCreado;
        public FormCompra()
        {
            InitializeComponent();
        }

        public Espectador Espectador
        {
            get
            {
                return espectadorCreado;
            }
        }

        private void btn_FinalizarCompra_Click(object sender, EventArgs e)
        {
            espectadorCreado = new Espectador(txt_Dni.Text, txt_Nombre.Text, txt_Telefono.Text, (int)numEntradas.Value);

            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
