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
using Centralita;
using CentralitaUI;

namespace CentralitaUI
{
    public partial class frmMostrar : Form
    {
        Llamada.TipoLlamada tipoLlamada;
        Centralita.Centralita central;
        public frmMostrar(Llamada.TipoLlamada tipoLlamada, Centralita.Centralita central)
        {
            InitializeComponent();
            this.tipoLlamada = tipoLlamada;
            this.central = central;
            CargarLlamadas();
        }

        private void CargarLlamadas()
        {
            StringBuilder sb = new StringBuilder();
            double acumulador = 0;
            foreach (Llamada item in central.Llamadas)
            {
                if(item is Local && tipoLlamada == Llamada.TipoLlamada.Local)
                {
                    sb.AppendLine(item.ToString());
                    acumulador += item.CostoLlamada;
                }
                else
                {
                    if(item is Provincial && tipoLlamada == Llamada.TipoLlamada.Provincial)
                    {
                        sb.AppendLine(item.ToString());
                        acumulador += item.CostoLlamada;
                    }
                    else
                    {
                        if (tipoLlamada == Llamada.TipoLlamada.Todas)
                        {
                            sb.AppendLine(item.ToString());
                            acumulador += item.CostoLlamada;
                        } 
                    }
                }
            }

            richTextBox1.Text = sb.ToString();
            lbl_Facturacion.Text = $"Facturación: ${acumulador}";

        }
    }
}
