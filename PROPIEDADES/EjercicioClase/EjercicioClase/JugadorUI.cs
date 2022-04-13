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

namespace EjercicioClase
{
    public partial class JugadorUI : Form
    {
        List<Jugador> list;
        public JugadorUI()
        {
            list = new List<Jugador>();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EPosicion posSeleccionada = (EPosicion)this.cmbPosicion.SelectedItem;
           
            Jugador jugadorCreado = new Jugador(txtNombre.Text, txtApellido.Text, txtDNI.Text, posSeleccionada, txtNumero.Text);
            list.Add(jugadorCreado);
        }

        public List<Jugador> GetJugadores()
        {
            return list;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void JugadorUI_Load(object sender, EventArgs e)
        {
            this.cmbPosicion.DataSource = Enum.GetValues(typeof(EPosicion));
        }
    }
}
