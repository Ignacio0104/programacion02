using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace EjercicioI02_Unidad05Registro
{
    public partial class frm_registro : Form
    {
        public frm_registro()
        {
            InitializeComponent();
        }

        private void frm_registro_Load(object sender, EventArgs e)
        {
            lbox_pais.Items.Add("Argentina");
            lbox_pais.Items.Add("Chile");
            lbox_pais.Items.Add("Uruguay");
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string genero = "";
            if (radio1_genero.Checked)
                genero = radio1_genero.Text;
            if (radio2_genero.Checked)
                genero = radio2_genero.Text;
            if (radio3_genero.Checked)
                genero = radio3_genero.Text;

            string[] cursos = new string[3];

            if (check1_cursos.Checked)
                cursos[0] = check1_cursos.Text;

            if (check2_cursos.Checked)
                cursos[1] = check2_cursos.Text;

            if (check3_cursos.Checked)
                cursos[2] = check3_cursos.Text;


            Ingresante alumno = new Ingresante(txt_nombre.Text, txt_direccion.Text.ToString(), genero, lbox_pais.SelectedItem.ToString(), cursos, (int)num_edad.Value);

            MessageBox.Show(alumno.Mostrar());
            
            
        }
    }
}
