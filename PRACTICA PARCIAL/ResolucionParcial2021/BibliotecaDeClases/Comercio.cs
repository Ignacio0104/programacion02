using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaDeClases
{
    public class Comercio : IBackup
    {
        private List<Cliente> clientes;

        public List<Cliente> Clientes { get => clientes; set => clientes = value; }
        public Comercio()
        {
            clientes = new List<Cliente>();
        }

        public static Comercio operator +(Comercio comercio, Cliente cliente)
        {
            int ultimoId = 0;
            if(comercio.clientes.Count > 0)
            {
                comercio.clientes.OrderBy(cliente => cliente.Numero);
                ultimoId = comercio.clientes[comercio.clientes.Count - 1].Numero;
            }
            cliente.Numero = ultimoId + 1;
            comercio.clientes.Add(cliente);
            return comercio;
        }

        public Cliente LlamarACliente()
        {
            Cliente clienteRetorno;
            if (this.clientes.Count < 1)
            {
                throw new SinClientesException("No hay clientes en la lista!");
            }
            else
            {
                clienteRetorno = clientes[0];
                clientes.Remove(clientes[0]);
            }

            return clienteRetorno;
        }

        public void LoadBackup(string path)
        {
            string archivo = string.Empty;
            List<Cliente> datos = default;
            string completa = path + @"\listaClientes.xml";

            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivos = Directory.GetFiles(completa);

                    foreach (string item in archivos)
                    {
                        if (item.Contains("listaClientes"))
                        {
                            archivo = item;
                            break;
                        }
                    }
                    if (archivo != null)
                    {
                        using (StreamReader sr = new StreamReader(completa))
                        {
                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Cliente>));
                            datos = (List<Cliente>)xmlSerializer.Deserialize(sr);
                        }
                    }
                }
                clientes = datos;
            }
            catch 
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    

        public void SaveBackup(string path)
        {
            string completa = path + @"\listaClientes.xml";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Cliente>));
                    xmlSerializer.Serialize(sw, clientes);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completa}");
            }
        }
    }
}
