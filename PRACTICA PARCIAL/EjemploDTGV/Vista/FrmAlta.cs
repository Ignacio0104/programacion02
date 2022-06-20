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

namespace Vista
{
    public partial class FrmAlta : Form
    {
        Juego juegoElegido;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            nupPrecio.Maximum = 10000;
            juegoElegido = JuegoDao.LeerPorId(codigoJuego);
            PintarForm();
        }

        private void PintarForm()
        {
            if (juegoElegido is not null)
            {
                txtNombre.Text = juegoElegido.Nombre;
                txtGenero.Text = juegoElegido.Genero;
                nupPrecio.Value = (decimal)juegoElegido.Precio;
                cmbUsuarios.Enabled = false;
            }
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDao.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text != "Modificar")
            {
                JuegoDao.Guardar(new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario));
            }
            else
            {
                JuegoDao.Modificar(new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, codigoJuego, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario));
            }
            DialogResult = DialogResult.OK;
        }
    }
}
