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
    public partial class MenuPrincipal : Form
    {
        private int idAlumno;
        private List<int> posicionesNullAlumnos;
        private List<int> posicionesNullProfesores;
        public MenuPrincipal(int id)
        {
            InitializeComponent();
            posicionesNullAlumnos = new List<int>();
            posicionesNullProfesores = new List<int>();
            idAlumno = id;     
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            int iterador = 0;
            lblBienvenido.Text += " alumno con ID:" + idAlumno;
            StringBuilder sb = new StringBuilder();
            try
            {
                foreach (Usuario item in Universidad.Alumnos)
                {
                    try
                    {
                        sb.AppendLine(item.ToString());
                    }
                    catch (Exception ex)
                    {
                        posicionesNullAlumnos.Add(iterador);
                    }
                    iterador++;
                }
                richTextBox1.Text = sb.ToString();
                sb.Clear();
                iterador = 0;
                foreach (Usuario item in Universidad.Profesores)
                {
                    try
                    {
                        sb.AppendLine(item.ToString());
                    }
                    catch (Exception ex)
                    {
                        posicionesNullProfesores.Add(iterador);
                    }
                    iterador++;
                }
                richTextBox2.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnErroresAlumnos_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Los siguientes ID dieron error \n\n";

            foreach (int item in posicionesNullAlumnos)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }

        private void btnErroresProfesores_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "Los siguientes ID dieron error \n\n";

           foreach (int item in posicionesNullProfesores)
            {
                richTextBox2.Text += item.ToString() + "\n";
            }
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
