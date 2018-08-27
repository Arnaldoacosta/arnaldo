using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form

    {
        #region "Declaraciones"

        List<Cliente> ListaClientes = new List<Cliente>();
        private int c = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {             
                openFileDialog.Filter = "in files (*.in)|*.in";
                DialogResult dr = openFileDialog.ShowDialog();
                
                if (dr == DialogResult.OK)
                {                  
                    string line;
                    // Lee archivo y carga linea al objeto y se agrega a la lista.  
                    
                    StreamReader file = new StreamReader(openFileDialog.FileName);
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] linea = line.Split('|');

                        c = c + 1;
                        //ValidarDatos();

                        Cliente cliente = new Cliente();

                        cliente.PersonId = int.Parse(linea[0]);
                        cliente.Name = linea[1];
                        cliente.LastName = linea[2];
                        cliente.CurrentRole = linea[3];
                        cliente.Country = linea[4];
                        cliente.Industry = linea[5];
                        cliente.NumberOfRecommendations = double.Parse(linea[6]);
                        cliente.NumberOfConnections = double.Parse(linea[7]);
                        ListaClientes.Add(cliente);
                    }

                 
                }

                btnObtenerArchivo.Enabled = true;
                btnCargarArchivo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Linea" + c.ToString(),"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }

        }

        private void btnObtenerArchivo_Click(object sender, EventArgs e)
        {
            //get clientes
           
                saveFileDialog1.FileName = "ClientesPotenciales.in";
                DialogResult dr = saveFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Ruta.Text = Ruta.Text + " " + saveFileDialog1.FileName;

                    List<Cliente> ListaClienteAux = new List<Cliente>();
                    foreach (var item in ListaClientes)
                    {
                        if (item.NumberOfConnections != 0)
                        {
                            item.IndiceClientePotencial = (item.NumberOfRecommendations / item.NumberOfConnections);
                            ListaClienteAux.Add(item);
                        }
                    }

                    int c = 0;
                    ListaClienteAux = ListaClienteAux.OrderByDescending(obj => obj.IndiceClientePotencial).ToList();
                    ListaClientes.Clear();

                    foreach (var item in ListaClienteAux)
                    {
                        c = c + 1;
                        if (c <= 100)
                            ListaClientes.Add(item);
                        else
                            break;
                    }


                    StreamWriter File1 = new StreamWriter(saveFileDialog1.FileName);
                    //escritura de archivo
                    try
                    {
                        foreach (Cliente item in ListaClientes)
                        {
                            File1.WriteLine(item.PersonId);
                        }
                        File1.Close();//cierra escritura.
                        Process.Start(saveFileDialog1.FileName);
                    btnCargarArchivo.Enabled = true;
                    btnObtenerArchivo.Enabled = false;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se puedo generar el archivo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }
    }

