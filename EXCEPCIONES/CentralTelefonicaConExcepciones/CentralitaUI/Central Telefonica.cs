using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;
using BibliotecaDeClases;

namespace CentralitaUI
{
    public partial class FrmMenu : Form
    {
        private Centralita.Centralita central;
        public FrmMenu()
        {
            InitializeComponent();
            central= new Centralita.Centralita("Telecentro");
        }

        private void btn_GenerarLlamada_Click(object sender, EventArgs e)
        {
            Llamador formLlamador = new Llamador(central);
            formLlamador.ShowDialog();
        }

        private void btn_FacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(Llamada.TipoLlamada.Todas,central);
            mostrar.ShowDialog();
        }

        private void btn_FacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(Llamada.TipoLlamada.Local, central);
            mostrar.ShowDialog();
        }

        private void btn_FacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar(Llamada.TipoLlamada.Provincial, central);
            mostrar.ShowDialog();
        }
    }
}
