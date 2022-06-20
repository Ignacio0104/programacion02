using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace UI
{
    public partial class FrmAtencionClientes : Form
    {
        Comercio comercioInstanciado;
        int clientesAtendidos;
        public FrmAtencionClientes()
        {
            InitializeComponent();
            comercioInstanciado = new Comercio();
        }

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Cliente> datos = default;
            string archivo = string.Empty;
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string completa = ruta + @"\backUpClientes.json";
            try
            {
                if (Directory.Exists(ruta))//Validamos que la carpeta exista
                {
                    string[] archivos = Directory.GetFiles(ruta); //Trae todas las rutas de los archivos

                    foreach (string item in archivos)
                    {
                        if (item.Contains("backUpClientes")) //Buscamos el archivo por nombre
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        JsonSerializerOptions options = new JsonSerializerOptions
                        {
                            Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) },

                        };
                        string archivoJson = File.ReadAllText(archivo);
                        datos = JsonSerializer.Deserialize<List<Cliente>>(archivoJson, options);
                    }
                }
                comercioInstanciado.Clientes = datos;
            }
            catch 
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string completa = ruta + @"\backUpClientes.json";

            try
            {
                if (!Directory.Exists(ruta))//Esto valida que si la carpeta no existe, se cree en el paso siguiente
                {
                    Directory.CreateDirectory(ruta); //Aca la creamos
                }
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }
                };
                string objetoJson = JsonSerializer.Serialize(comercioInstanciado.Clientes, options);

                File.WriteAllText(completa, objetoJson);

            }
            catch 
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente frm = new FrmAgregarCliente();
            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                comercioInstanciado += frm.clienteCreado;
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            FrmSimularAtencion frmAtencion = new FrmSimularAtencion(comercioInstanciado);
            frmAtencion.ShowDialog();
            MessageBox.Show($"Se atendieron a {frmAtencion.clientesAtendidos.ToString()} clientes");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente item in comercioInstanciado.Clientes)
            {
                sb.AppendLine($"{item.Numero} - {item.Nombre}");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}
