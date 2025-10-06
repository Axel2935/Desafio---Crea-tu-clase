using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CrearTuClase
{
    internal class App
    {
        #region Atributos

        private string nombre;
        private double tamanio;
        private double ramRequerida;
        private EnumApp tipo;
        private double precio;
        private bool aplicacionActiva;

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public double Tamanio
        {
            get { return this.tamanio; }
        }

        public double RamRequerida
        {
            get { return this.ramRequerida; }
        }

        public EnumApp Tipo
        {
            get { return this.tipo; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public bool AplicacionActiva
        {
            get { return this.aplicacionActiva; }
            set { this.aplicacionActiva = value; }
        }

        #endregion

        #region Constructores
        public App()
        {
            this.aplicacionActiva = false;
            this.precio = 0;
        }
        public App(string nombre, double tamanio, double ramRequerida, EnumApp tipo):this()
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
            this.ramRequerida = ramRequerida;
            this.tipo = tipo;
        }

        public App(string nombre, double tamanio, double ramRequerida, EnumApp tipo, double precio):this(nombre, tamanio, ramRequerida, tipo)
        {
            this.precio=precio;
        }

        #endregion
    }
}