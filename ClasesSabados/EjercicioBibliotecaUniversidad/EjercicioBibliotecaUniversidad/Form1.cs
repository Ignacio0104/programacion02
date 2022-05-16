using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaUniversidad;

namespace EjercicioBibliotecaUniversidad
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idAux;

            int.TryParse(txtUsuario.Text, out idAux);

            try
            {
                if(Universidad.Loguear(idAux, txtClave.Text))
                {
                    MenuPrincipal frmPrincipal = new MenuPrincipal(idAux);
                    this.Hide();
                    frmPrincipal.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAutoCompletar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "123123";
            txtClave.Text = "lucas123";
        }
    }
}
