using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI03_Unidad06ContarPalabras
{
    public partial class frmContador : Form
    {
        Dictionary<string, int> lista;
        public frmContador()
        {
            InitializeComponent();
            lista = new Dictionary<string, int>();
        }

        public void recorrerRichText()
        {
            string input = richTxt.Text;
            StringBuilder palabra = new StringBuilder();

            for (int i = 0; i < input.Length;  i++)
            {
                if(input[i].ToString()!= " ")
                {
                    palabra.Append(input[i]);
                }
                else
                {
                    if (lista.ContainsKey(palabra.ToString()))
                    {
                        lista[palabra.ToString()]++;
                    }
                    else
                    {
                        lista.Add(palabra.ToString(), 1);
                    }
                    palabra.Clear();
                }
            }
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            recorrerRichText();
            StringBuilder mensaje = new StringBuilder();
            var sortedItem = from data in lista orderby data.Value descending select data;
            int index = 1;
            foreach (var item in sortedItem)
            {
                mensaje.AppendLine($"Puesto {index}: {item.Key} - {item.Value} veces");
                if(index == 3)
                {
                    break;
                }
                else
                {
                    index++;
                }
            }

            MessageBox.Show(mensaje.ToString());
        }
    }

}
