using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI01_Unidad01HolaWindows
{
    public partial class Mensaje : Form
    {
        public Mensaje(string nombre, string apellido, string materia)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Soy {nombre} {apellido}");
            sb.AppendLine($"Mi materia favorita es {materia}");
     
            lbl_mensajeSecundario.Text = sb.ToString();
        }

        private void Mensaje_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
