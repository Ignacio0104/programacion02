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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        string[] materias = new string[6];

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txt_Nombre.Text) && !String.IsNullOrWhiteSpace(txt_Apellido.Text))
            {
                Mensaje frm = new Mensaje(txt_Nombre.Text, txt_Apellido.Text,box_materias.SelectedItem.ToString());

                frm.Show();

                this.Hide();
            }
            else {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Error, se deben completar los siguientes campos:");
                if (String.IsNullOrWhiteSpace(txt_Nombre.Text))
                {
                    sb.AppendLine("Nombre");
                }

                if (String.IsNullOrWhiteSpace(txt_Apellido.Text))
                {
                    sb.AppendLine("Apellido");
                }
                MessageBox.Show(sb.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            materias[0] = "Laboratorio II";
            materias[1] = "Programacion II";
            materias[2] = "Arquitectura de Sistemas operativos";
            materias[3] = "Ingles II";
            materias[4] = "Metodologia";
            materias[5] = "Estadistica";

            box_materias.Items.Add(materias[0]);
            box_materias.Items.Add(materias[1]);
            box_materias.Items.Add(materias[2]);
            box_materias.Items.Add(materias[3]);
            box_materias.Items.Add(materias[4]);
            box_materias.Items.Add(materias[5]);

            box_materias.SelectedIndex = 0;

        }

 
    }
}
