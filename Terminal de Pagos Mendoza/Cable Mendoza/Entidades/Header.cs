using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Header
    {
        //VARIABLES DEL HEADER
        private string tipoDeHeader; //1 Caracater
        private string valorFijo; //3 Caracater
        private string numComercio; //4 Caracater
        private string fecha; //8 Caracater FORMATO AAAAMMDD
        //Cantidad de caracteres 16


        public Header(string tipoDeHeader, string valorFijo, string numComercio, string fecha)
        {
            this.tipoDeHeader = tipoDeHeader;
            this.valorFijo = valorFijo;
            this.numComercio = numComercio;
            this.fecha = fecha;
        }
       




    }
}
