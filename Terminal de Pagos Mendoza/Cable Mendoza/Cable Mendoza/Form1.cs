using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using SesionIniciada;
using System.IO;

namespace Cable_Mendoza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BtnNumCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            this.lblDNI.Text = "";
            bool retorno = Validaciones.ValidarQueSeaDni(this.txtDNI.Text, out int dni);
            if (retorno == false)
            {
                this.lblDNI.Text = "DNI invalido";
            }
            else 
            {

                if (TieneDeuda(dni))
                {
                    MiSesionIniciada mi = new MiSesionIniciada();

                    mi.Registro(dni);
                    mi.VerMiDeuda(dni);
                    mi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Este DNI no presenta facturas pendientes");
                    //MOSTRA Q NO TIENE DEUDA
                }
                
            }
        }


        public bool TieneDeuda(int dni)
        {
            Archivos archivo = new Archivos();
            Deuda deuda;
            string path = Directory.GetCurrentDirectory();
            path += "\\informacion.txt";
            archivo.Leer(path, out deuda);
            bool retorno = deuda.BuscarDNI(dni.ToString());

            return  retorno;
        }


        private void ShowMyNonModalForm()
        {
            Form myForm = new Form();
            myForm.Text = "My Form";
            myForm.SetBounds(10, 10, 200, 200);

            myForm.Show();
            // Determine if the form is modal.
            if (myForm.Modal == true)
            {
                // Change borderstyle and make it not a top level window.
                myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                myForm.TopLevel = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           MostrarPantallaCompleta();
        }

        private void MostrarPantallaCompleta()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
