using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01El_delegado
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar formularioMostrar;
        private FrmTestDelegados formularioDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            formularioMostrar = new FrmMostrar();
            formularioMostrar.MdiParent = this;
            formularioDelegados = new FrmTestDelegados(formularioMostrar.ActualizarNombre);
            //Se le puede pasar null a este form. Y luego el delegado tira null Exception
            formularioDelegados.MdiParent = this;
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioDelegados.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioMostrar.Show();
        }
    }
}
