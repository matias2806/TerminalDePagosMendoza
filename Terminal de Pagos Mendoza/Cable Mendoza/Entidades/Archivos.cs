using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Archivos
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="archivo">ruta del archivo</param>
        /// <param name="datos">datos a ser guardado</param>
        /// <returns>true si funciono false si no</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, false, UTF8Encoding.ASCII))
                {
                    sw.WriteLine(datos);
                    retorno = true;
                }
            }
            catch (Exception)
            {
                throw new Exception("Error Guardar");
            }

            return retorno;
        }


        
        public bool Leer(string archivo, out Deuda deuda)
        {
            bool retorno = false;

            Header header = null;
            List<Detalle> miListaDeDetalle = new List<Detalle>();
            Footer footer = null;

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string auxiliarLine = line;
                        string tipoLinea = line.Substring(0, 1);

                        if (tipoLinea == "0")
                        {
                            string tipoDeHeader = line.Substring(0, 1);
                            string valorFijo = line.Substring(1, 3);
                            string numComercio = line.Substring(4, 4);
                            string fecha = line.Substring(8, 8);
                            header = new Header(tipoDeHeader, valorFijo, numComercio, fecha);
                        }
                        if (tipoLinea == "5") {
                            string tipoDeDetalle = line.Substring(0, 1); //1 Caracater
                            string numCliente = line.Substring(1, 19); //19 Caracater
                            string documento = line.Substring(20, 20); //20 Caracater
                            string moneda = line.Substring(40, 1); //1 Caracater
                            string primerVencimiento = line.Substring(41, 8); //8 Caracater
                            string importePrimerVencimiento = line.Substring(49, 11); //11 Caracater
                            string segundoVencimiento = line.Substring(60, 8); //8 Caracater
                            string importeSegundoVencimiento = line.Substring(68, 11); //11 Caracater
                            string tercerVencimiento = line.Substring(79, 8); //8 Caracater
                            string importeTercerVencimiento = line.Substring(87, 11); //11 Caracater
                            string valorFijoSegundo = line.Substring(98, 19); //19 Caracater
                            string numReferencia = line.Substring(117, 19); //19 Caracater
                            string mensajeTicket = line.Substring(136, 55); //55 Caracater
                            string codBarras = line.Substring(191, 38); //38 Caracater

                            Detalle detalle = new Detalle(tipoDeDetalle, numCliente, documento,
                                moneda, primerVencimiento, importePrimerVencimiento,
                                segundoVencimiento, importeSegundoVencimiento, tercerVencimiento,
                                importeTercerVencimiento, valorFijoSegundo, numReferencia,
                                mensajeTicket, codBarras);

                            miListaDeDetalle.Add(detalle);
                        }
                        if (tipoLinea == "9")
                        {
                            string tipoDeFooter = line.Substring(0, 1); //1 Caracater
                            string valorFijoFooter = line.Substring(1, 3); //3 Caracater
                            string comercio = line.Substring(4, 4); //4 Caracater
                            string fechaFotter = line.Substring(8, 8); //8 Caracater formato AAAAMMDD
                            string cantRegistros = line.Substring(16, 7); //7 Caracater
                            string valorFijoSegundoDelFooter = line.Substring(23, 7); //7 Caracater
                            string importe = line.Substring(30, 11); //11 Caracater

                            footer = new Footer(tipoDeFooter, valorFijoFooter, comercio,
                                fechaFotter, cantRegistros, valorFijoSegundoDelFooter, importe);
                        }
                    }

                    Deuda deudaArchivo = new Deuda(header, miListaDeDetalle, footer);
                    retorno = true;
                    deuda = deudaArchivo;
                }
            }
            catch (Exception )
            {
                throw new Exception("Error Leer");
            }
            return retorno;
        }


        public void AbrirArchivo()
        {

        }

        public void ParsearArchivo()
        {

        }

    }
}
