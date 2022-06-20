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

namespace UI
{
    public partial class FrmSimularAtencion : Form
    {
        Comercio comercio;
        Simulador simulador;
        int indiceDeCliente = 0;
        public int clientesAtendidos = 0;
        public FrmSimularAtencion(Comercio comercio)
        {
            InitializeComponent();
            this.comercio = comercio;
            this.simulador = new Simulador(comercio);
            simulador.MostrarInformacion += MostrarCliente;
        }

        public void MostrarCliente()
        {
            try
            {
                if (lblDatos.InvokeRequired)
                {
                    Action delegadoAux = MostrarCliente;
                    lblDatos.Invoke(delegadoAux);
                }
                else
                {
                    lblDatos.Text = $"{comercio.LlamarACliente().Numero} - {comercio.LlamarACliente().Nombre}";
                    indiceDeCliente++;
                    if (indiceDeCliente > comercio.Clientes.Count)
                    {
                        simulador.cts.Cancel();
                    }
                }


            }catch (SinClientesException ex)
            {
                simulador.cts.Cancel();
                this.Close();
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmSimularAtencion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                clientesAtendidos = simulador.atendidos;
                simulador.cts.Cancel();
                this.Close();
            }
  
        }

        private void FrmSimularAtencion_Load(object sender, EventArgs e)
        {
            simulador.ComenzarSimulacion();
        }
    }
}
