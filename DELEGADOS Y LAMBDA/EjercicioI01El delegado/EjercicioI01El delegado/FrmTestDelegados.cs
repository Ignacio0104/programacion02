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
    public partial class FrmTestDelegados : Form
    {
        //public delegate void DelegadoVoid(string nombre);
        public Action<string> delegadoActualizar;
        //DelegadoVoid delegadoActualizar;
        public FrmTestDelegados(/*DelegadoVoid delegadoActualizar*/Action<string> delegadoActualizar)
        {
            InitializeComponent();
            this.delegadoActualizar = delegadoActualizar;
        }
     
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(delegadoActualizar is not null)
                delegadoActualizar.Invoke(txtNombre.Text);
        }
    }
}
