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


namespace EjercicioC01_Temporizador
{
    public partial class Form1 : Form
    {
        private Temporizador temporizador;
        public Form1()
        {
            InitializeComponent();
            temporizador = new Temporizador(1000);
            temporizador.TiempoCumplido += AsignarHora;
            temporizador.YaEstaApagado += MostrarQueEstaApagado;
            temporizador.YaEstaPrendido += MostrarQueEstaPrendido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarHoraConClaseTemporizador();
        }

        public void ActualizarHoraConClaseTemporizador()
        {
            temporizador.IniciarTemporizador();
        }

        private void AsignarHora()
        {
            if (lblReloj.InvokeRequired)
            {
                Action delegadoAsignarHora = AsignarHora;
                lblReloj.Invoke(delegadoAsignarHora);
            }
            else
            {
                lblReloj.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            temporizador.IniciarTemporizador();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            temporizador.DetenerTemporizador();
        }

        private void MostrarQueEstaPrendido()
        {
            MessageBox.Show("El reloj ya está prendido");
        }

        private void MostrarQueEstaApagado()
        {
            MessageBox.Show("El reloj ya está apagado");
        }
    }
}
