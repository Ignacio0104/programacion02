using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase06_windowsForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string usuario = "pepe";
        private string pwd = "RuFoSo";

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Detectar el textbox

            string userInput = this.usuarioInput.Text.ToLower();
            string pwdInput = this.pwdInput.Text;

            //TODO : 2 - Reemplazar el texto en el LABEL

            if(userInput == this.usuario && pwdInput ==this.pwd)
            {
                MessageBox.Show("Estas logueado");

                MenuPrincipal frm = new MenuPrincipal();

                frm.Show();

                this.Hide();
          
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

    }
}
