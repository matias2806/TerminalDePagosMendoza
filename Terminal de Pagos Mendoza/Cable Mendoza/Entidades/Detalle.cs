﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle
    {
        //VARIABLES DEL DETALLE
        private string tipoDeDetalle; //1 Caracater
        private string numCliente; //19 Caracater
        private string documento; //20 Caracater
        private string moneda; //1 Caracater
        private string primerVencimiento; //8 Caracater
        private string importePrimerVencimiento; //11 Caracater
        private string segundoVencimiento; //8 Caracater
        private string importeSegundoVencimiento; //11 Caracater
        private string tercerVencimiento; //8 Caracater
        private string importeTercerVencimiento; //11 Caracater
        private string valorFijoSegundo; //19 Caracater
        private string numReferencia; //19 Caracater
        private string mensajeTicket; //55 Caracater
        private string codBarras; //38 Caracater
        //Cantidad de caracteres 229

        public Detalle(string tipoDeDetalle, string numCliente, string documento, 
            string moneda, string primerVencimiento, string importePrimerVencimiento, 
            string segundoVencimiento, string importeSegundoVencimiento, 
            string tercerVencimiento, string importeTercerVencimiento, 
            string valorFijoSegundo, string numReferencia, string mensajeTicket, 
            string codBarras)
        {
            this.tipoDeDetalle = tipoDeDetalle;
            this.numCliente = numCliente;
            this.documento = documento;
            this.moneda = moneda;
            this.primerVencimiento = primerVencimiento;
            this.importePrimerVencimiento = importePrimerVencimiento;
            this.segundoVencimiento = segundoVencimiento;
            this.importeSegundoVencimiento = importeSegundoVencimiento;
            this.tercerVencimiento = tercerVencimiento;
            this.importeTercerVencimiento = importeTercerVencimiento;
            this.valorFijoSegundo = valorFijoSegundo;
            this.numReferencia = numReferencia;
            this.mensajeTicket = mensajeTicket;
            this.codBarras = codBarras;
        }
        //Cantidad de caracteres 229

        public bool SonIguales( string dni)
        {
            bool retorno = false;
            string aux = this.numCliente.Trim();
            if (dni == aux)
            {
                retorno = true;
            }
            return retorno;
        }


        #region Setter y Getters

        public string NumCliente
        {
            get { return numCliente; }
            set { numCliente = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string PrimerVencimiento
        {
            get { return primerVencimiento; }
            set { primerVencimiento = value; }
        }

        public string ImportePrimerVencimiento
        {
            get { return importePrimerVencimiento; }
            set { importePrimerVencimiento = value; }
        }

        public string SegundoVencimiento
        {
            get { return segundoVencimiento; }
            set { segundoVencimiento = value; }
        }

        public string ImporteSegundoVencimiento
        {
            get { return importeSegundoVencimiento; }
            set { importeSegundoVencimiento = value; }
        }
        public string TercerVencimiento
        {
            get { return tercerVencimiento; }
            set { tercerVencimiento = value; }
        }

        public string ImporteTercerVencimiento
        {
            get { return importeTercerVencimiento; }
            set { importeTercerVencimiento = value; }
        }
        #endregion

    }

}
