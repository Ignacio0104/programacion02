using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmPrincipal : Form
    {
        FrmMostrar formularioMostrar;
        FrmTesteDelegados formularioTest;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            formularioMostrar = new FrmMostrar();
            formularioMostrar.MdiParent = this;
            formularioTest = new FrmTesteDelegados(formularioMostrar.ActualizarNombre);
            formularioTest.MdiParent = this;

        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioTest.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularioMostrar.Show();

        }
    }
}
