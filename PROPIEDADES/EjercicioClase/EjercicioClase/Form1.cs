using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JugadorUI frmAltaJugador = new JugadorUI();
            DialogResult resultado = frmAltaJugador.ShowDialog();

            /*if (resultado == DialogResult.OK)
            {
                int posLibre = ProximaPos();

                if (posLibre != -1)
                {
                    alumnos[posLibre] = frmAltaAlumno.GetAlumno();

                    this.rtb_informacion.Text += frmAltaAlumno.GetAlumno().MostrarInfo() + "\n";

                    //this.rtb_informacion.Text += alumnos[posLibre].MostrarInfo() + "\n";

                }
                else
                {
                    MessageBox.Show("NO HAY MAS LUGAR");
                }
            }
            else
            {
                MessageBox.Show("Carga cancelada");
            }*/
        }
    }
}
