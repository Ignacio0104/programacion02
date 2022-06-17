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

namespace EjercicioI01_AvisameSiCambia
{
    public partial class Form1 : Form
    {
        private Persona persona;
        public Form1()
        {
            InitializeComponent();
            if(persona is null)
            {
                button1.Text = "Crear";
            }
        }

        public void NotificarCambio(string cadena)
        {
            MessageBox.Show(cadena);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(persona is null)
            {
                persona = new Persona(textBox1.Text, textBox2.Text);
                persona.EventoString += NotificarCambio;
            }
            else
            {
                persona.Nombre = textBox1.Text;
                persona.Apellido = textBox2.Text;
            }

            button1.Text = "Actualizar";
            label1.Text = persona.Mostrar();
        }
    }
}
