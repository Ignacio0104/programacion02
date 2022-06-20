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
    public partial class FrmTesteDelegados : Form
    {
        public delegate void DelegadoMostrar(string nombre);
        DelegadoMostrar delegado;
        public FrmTesteDelegados(DelegadoMostrar delegado)
        {
            InitializeComponent();
            this.delegado = delegado;
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            delegado.Invoke(textBox1.Text);
        }
    }
}
