using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;



namespace SesionIniciada
{
    public partial class MiSesionIniciada : Form
    {
        public DataTable tabla;
        public MiSesionIniciada()
        {
            InitializeComponent();
            MostrarPantallaCompleta();
            //string a = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            string path = Directory.GetCurrentDirectory();
            path += "\\Icitelco.png";
            pictureBox1.Image = Image.FromFile(path);

            
        }

        private void MostrarPantallaCompleta()
        {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }


        

        public void VerMiDeuda(int dni)
        {
            Archivos archivo = new Archivos();
            Deuda deuda;

            string path = Directory.GetCurrentDirectory();
            path += "\\informacion.txt";

            archivo.Leer(path, out deuda);
            // this.lblPrueba.Text = deuda;

            List<Detalle> deudaSujeto = null;
            if(deuda.BuscarDNI(dni.ToString(), out deudaSujeto))
            {
                IniciarTabla();
                CargarDeuda(deudaSujeto);
                this.lblTotalAPagar.Text = TotalDeuda(deudaSujeto).ToString()+" $";
                //SUJETO CON DEUDAS
            }
            else
            {
                //SUJETO SIN DEUDA
            }
        }

        private int ObtenerDiaFormato()
        {
            DateTime fecha = DateTime.Today;
            int dia = fecha.Day;
            int mes = fecha.Month;
            int anio = fecha.Year;

            string diaString = dia.ToString();
            string mesString = mes.ToString();
            string anioString = anio.ToString();

            if (mesString.Length == 1)
            {
                mesString = 0 + mesString;
            }
            if (diaString.Length == 1)
            {
                diaString = 0 + diaString;
            }
            string diaHoy = anioString + mesString + diaString;
            int diaInt = int.Parse(diaHoy);
            return diaInt;
        }


        private int TotalDeuda(List<Detalle> deudaSujeto)
        {
            int montoTotal = 0;
            int diaHoy = ObtenerDiaFormato();
            bool flag = false;
            
            foreach (Detalle item in deudaSujeto)
            {
                flag = false;
                int primerVen = int.Parse(item.PrimerVencimiento);
                int segundoVev = int.Parse(item.SegundoVencimiento);
                int tercerVen = int.Parse(item.TercerVencimiento);

                if(diaHoy <= primerVen)
                {
                    montoTotal += int.Parse(item.ImportePrimerVencimiento);
                    flag = true;
                }
                if (diaHoy <= segundoVev && flag == false)
                {
                    montoTotal += int.Parse(item.ImporteSegundoVencimiento);
                    flag = true;
                }
                if(flag == false)
                {
                    montoTotal += int.Parse(item.ImporteTercerVencimiento);
                    flag = true;
                }
            }
            return montoTotal;
        }

        private void IniciarTabla()
        {
            tabla = new DataTable();
            tabla.Columns.Add("NumCliente");
            tabla.Columns.Add("Documento");
            tabla.Columns.Add("1er vencimiento");
            tabla.Columns.Add("Importe 1er vencimiento");
            tabla.Columns.Add("2do vencimiento");
            tabla.Columns.Add("Importe 2do vencimiento");
            tabla.Columns.Add("3er vencimiento");
            tabla.Columns.Add("Importe 3er vencimiento");
            tabla.Columns.Add("Abonar Factura");
            this.grilla.DataSource = tabla;
        }

        


        private void CargarDeuda(List<Detalle> deudaSujeto)
        {
            foreach(Detalle item in deudaSujeto)
            {
                DataRow fila = tabla.NewRow();
                fila["NumCliente"] = item.NumCliente;
                fila["Documento"] = item.Documento;
                fila["1er vencimiento"] = item.PrimerVencimiento;
                fila["Importe 1er vencimiento"] = item.ImportePrimerVencimiento;
                fila["2do vencimiento"] = item.SegundoVencimiento;
                fila["Importe 2do vencimiento"] = item.ImporteSegundoVencimiento;
                fila["3er vencimiento"] = item.TercerVencimiento;
                fila["Importe 3er vencimiento"] = item.ImporteTercerVencimiento;
                fila["Abonar Factura"] = "ACA TENGO QUE PONER UN BOTON";
                tabla.Rows.Add(fila);
            }
        }

        public void Registro(int dni)
        {
            this.lbl_DNI.Text = dni.ToString();

        }

        public string BuscarNumDeSocio(string dni)
        {
            return "Numero de Socio";
        }
        public string BuscarDNI(string numSocio)
        {
            return "Numero de DNI";
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
