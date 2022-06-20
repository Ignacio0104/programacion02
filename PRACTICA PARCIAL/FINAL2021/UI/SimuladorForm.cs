using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace UI
{
    public partial class SimuladorForm : Form
    {
        Thread hilo;

        public SimuladorForm()
        {
            InitializeComponent();
            cmbMicroorganismo.Items.Add("Covid-19");
            cmbMicroorganismo.Items.Add("Gripe");
            cmbMicroorganismo.SelectedIndex = 0;
            GrupoDePrueba<Microrganismo>.InformeDeAvance += Informe;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {        
            if (cmbMicroorganismo.SelectedIndex == 0)
            {
                Covid19 covid = new Covid19("Cepa brasilera");
                Ejecutar<Covid19>(covid);
   
            }
            else
            {
                Gripe gripe = new Gripe("Gripe porcina", Enumerados.ETipo.Bacteria, Enumerados.EContagiosidad.Baja);
                Ejecutar<Gripe>(gripe);

            }
        }

        private void Ejecutar<T>(T enfermedad)
        {
            long.TryParse(txtPoblacion.Text, out long numero);
            long poblacionAux = numero;
            GrupoDePrueba<Microrganismo>.Poblacion = poblacionAux;
            Task tarea = Task.Run(() =>
            {
                GrupoDePrueba<Microrganismo>.InfectarPoblcacion(enfermedad);
            });           
        }

        private void Informe(int dia, long infectados)
        {
            Task tarea = Task.Run(() =>
            {
                Informar(dia, infectados);
            });
        }

        private void Informar(int dia, long infectados)
        {
            if (richEvolucion.InvokeRequired)
            {
                Action<int, long> delegadoAux = Informe;
                delegadoAux.Invoke(dia, infectados);
            }
            else
            {
                MessageBox.Show("Llamado");
                richEvolucion.Text += $"Día {dia}: {infectados} infectados de la población total";
            }
        }
    }
}
