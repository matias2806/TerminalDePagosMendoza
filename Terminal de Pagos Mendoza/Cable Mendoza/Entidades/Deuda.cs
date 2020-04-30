using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deuda
    {
        //VARIABLES DEL HEADER
        private Header header;
        //Cantidad de caracteres 16

        //VARIABLES DEL DETALLE
        private List<Detalle> detalles;
        //Cantidad de caracteres 229

        //VARIABLES DEL FOOTER
        private Footer footer;
        //Cantidad de caracteres 41

        public Deuda(Header header, List<Detalle> detalles, Footer footer)
        {
            this.header = header;
            this.detalles = detalles;
            this.footer = footer;
        }


        public bool BuscarDNI(string dni, out List<Detalle> listadoDeuda)
        {
            bool retorno = false;
            listadoDeuda = new List<Detalle>();
            foreach (Detalle item in this.detalles)
            {
                if (item.SonIguales(dni))
                {
                    retorno = true;
                    listadoDeuda.Add(item);
                }
            }
            return retorno;
        }


        public bool BuscarDNI(string dni)
        {
            bool retorno = false;
            foreach (Detalle item in this.detalles)
            {
                if (item.SonIguales(dni))
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }











    }
}
