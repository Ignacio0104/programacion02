using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioI02_Atrapame_si_puedes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtKilometros.Text == "" && txtLibros.Text == "")
                {
                    throw new ParametrosVaciosException("Parametros vacios");
                }

                richTextBox1.Text = $"{Calculator.Calcular(int.Parse(txtKilometros.Text), int.Parse(txtLibros.Text))}";

                
            }
            catch (ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }
    }
}
