using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita;
using CentralitaUI;

namespace CentralitaUI
{
    public partial class Llamador : Form
    {
        Centralita.Centralita central;
        public Centralita.Centralita Central
        {
            get
            {
                return central;
            }
        }
        public Llamador(Centralita.Centralita central)
        {
            InitializeComponent();
            cmb_Franja.DataSource = Enum.GetValues(typeof(Centralita.Provincial.Franja));
            this.central = central;
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txt_NroDestino.Text += button.Text;
        }

        private void txt_NroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txt_NroDestino.Text.Length > 0 && txt_NroDestino.Text[0] == '#')
            {
                cmb_Franja.Enabled = false;
            }
            else
            {
                cmb_Franja.Enabled = true;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_NroDestino.Text = "";
            txt_NroOrigen.Text = "";
        }

        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se registró la llamada correctamente");

            if (cmb_Franja.Enabled == true)
            {
                Centralita.Provincial.Franja franja = ((Centralita.Provincial.Franja)cmb_Franja.SelectedItem);
                Provincial llamada = new Provincial(txt_NroOrigen.Text, franja, rnd.Next(1, 50), txt_NroDestino.Text);
                central += llamada;
                sb.AppendLine(llamada.ToString());
            }
            else
            {
                Local llamada = new Local(rnd.Next(1, 50), txt_NroDestino.Text, txt_NroOrigen.Text, ((float)rnd.Next(5, 56) / 10));
                central += llamada;
                sb.AppendLine(llamada.ToString());
            }

            MessageBox.Show(sb.ToString());
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMenu menu = new FrmMenu();
     
        }
    }
}
