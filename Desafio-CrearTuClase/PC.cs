using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CrearTuClase
{
    internal class PC
    {
        #region Atrinutos

        private string sistemaOperativo;
        private string procesador;
        private double ramUsada;
        private double almacenamientoUsado;
        private List<App> aplicacionesInstaladas;
        private List<App> aplicacionesActivas;

        #endregion


        #region Propiedades

        public string SistemaOperativo
        {
            get { return this.sistemaOperativo; }
        }

        public string Procesador
        {
            get { return this.procesador; }
            set { this.procesador = value; }
        }

        public double Ram
        {
            get;
            set;
        }

        public double RamUsada
        {
            get { return this.ramUsada; }
        }

        public double RamDisponible
        {
            get
            {
                return Ram - RamUsada;
            }
        }

        public double AlmacenamientoTotal
        {
            get;
            set;
        }

        public double AlmacenamientoUsado
        {
            get { return this.almacenamientoUsado; }
        }

        public double AlmacenamientoDisponible
        {
            get
            {
                return AlmacenamientoTotal - AlmacenamientoUsado;
            }
        }

        #endregion


        #region Constructores

        public PC()
        {
            this.sistemaOperativo = "Windows";
            this.aplicacionesInstaladas = new List<App>();
            this.aplicacionesActivas = new List<App>();
            this.ramUsada = 3.5;
            this.almacenamientoUsado = 40;
        }

        public PC(string procesador, double ram) : this()
        {
            this.procesador = procesador;
            Ram = ram;
        }

        public PC(string procesador, double ram, double almacenamientoTotal) : this(procesador, ram)
        {
            AlmacenamientoTotal = almacenamientoTotal;
        }
        #endregion


        #region Metodos

        public string MostrarInfo()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(this.sistemaOperativo);
            mensaje.AppendLine($"Porcesador: {this.procesador}");
            mensaje.AppendLine($"Ram total:{Ram}");
            mensaje.AppendLine($"Ram usada: {this.ramUsada}");
            mensaje.AppendLine($"Ram disponible: {RamDisponible}");
            mensaje.AppendLine($"Almacenamiento total: {AlmacenamientoTotal}");
            mensaje.AppendLine($"Almacenamiento usado: {this.almacenamientoUsado}");
            mensaje.AppendLine($"Almacenamiento disponible: {AlmacenamientoDisponible}");
            return mensaje.ToString();
        }

        public bool InstalarApp(App app)
        {
            if (app == null) //lo repito mucho, separarlo mas tarde
            {
                Console.WriteLine("no existe");
                return false;
            }
            else if (AlmacenamientoDisponible < app.Tamanio)
            {
                Console.WriteLine("No hay espacio suficiente");
                return false;
            }
            //poner si se tiene el saldo suficente
            foreach (App appAInstalar in this.aplicacionesInstaladas)
            {
                if (appAInstalar.Nombre == app.Nombre)
                {
                    Console.WriteLine("Esta app ya esta instalada");
                    return false;
                }
            }
            this.aplicacionesInstaladas.Add(app);
            this.almacenamientoUsado += app.Tamanio;
            //-= app.Precio
            Console.WriteLine($"Se logro instalar {app.Nombre} ({app.Tamanio} GB) correctamente");
            return true;
        }

        public bool DesintalarApp(App app)
        {
            if (app == null)
            {
                Console.WriteLine("app no existe");
                return false;
            }
            foreach (App appADesintalar in this.aplicacionesInstaladas)
            {
                if (appADesintalar.Nombre == app.Nombre)
                {
                    this.aplicacionesInstaladas.Remove(app);
                    this.almacenamientoUsado -= app.Tamanio;
                    Console.WriteLine($"Se desintalo {app.Nombre}");
                    return true;
                }
            }
            Console.WriteLine("No tenes la aplicacion en tu PC");
            return false;
        }

        public string AdministradorDeAlmacenamiento() //dividir en varios metodos o algo para q no sea tan grande
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Tus aplicaciones: ");
            foreach (App app in this.aplicacionesInstaladas)
                {
                mensaje.AppendLine($"{app.Nombre} - {app.Tamanio} GB");
                }
            mensaje.AppendLine("Distribucion de Almacenamiento usado por tipo de aplicacion");
            double tamanioJuegos = 0;
            double tamanioRedesSociales = 0;
            double tamanioHerramientas = 0;
            double tamanioMultimedia = 0;
            double tamanioPersonalizacion = 0;
            double tamanioNavegador = 0;
            double tamanioOtros = 0;
            foreach (App app in this.aplicacionesInstaladas)
            {
                switch (app.Tipo)
                {
                    case EnumApp.Juego:
                    {
                        tamanioJuegos += app.Tamanio;
                        break;
                    }
                    case EnumApp.RedSocial:
                        {
                            tamanioRedesSociales += app.Tamanio;
                            break;
                        }
                    case EnumApp.Herramienta:
                        {
                            tamanioHerramientas += app.Tamanio;
                            break;
                        }
                    case EnumApp.Multimedia:
                        {
                            tamanioMultimedia += app.Tamanio;
                            break;
                        }
                    case EnumApp.Personalizacion:
                        {
                            tamanioPersonalizacion += app.Tamanio;
                            break;
                        }
                    case EnumApp.Navegador:
                        {
                            tamanioNavegador += app.Tamanio;
                            break;
                        }
                    case EnumApp.Otro:
                        {
                            tamanioOtros += app.Tamanio;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            mensaje.AppendLine($"Espacio usado en Juegos: {tamanioJuegos.ToString("F2")} GB"); //ver si encuentro algo para esto
            mensaje.AppendLine($"Espacio usado en Redes Sociales: {tamanioRedesSociales} GB");
            mensaje.AppendLine($"Espacio usado en Multimedia: {tamanioMultimedia} GB");
            mensaje.AppendLine($"Espacio usado en Personalizacion: {tamanioPersonalizacion} GB");
            mensaje.AppendLine($"Espacio usado en Navagedaro: {tamanioNavegador} GB");

            return mensaje.ToString();
        }

        public bool AbrirApp(App app)
        {
            if (app == null)
            {
                return false;
            }
            else if (RamDisponible < app.RamRequerida)
            {
                Console.WriteLine("No se pudo abrir por falta de ram");
                return false;
            }
            foreach (App aplicacion in this.aplicacionesInstaladas)
            {
                if (aplicacion.Nombre == app.Nombre)
                {
                    app.AplicacionActiva = true;
                    this.aplicacionesActivas.Add(app); //poner condicion de que si es de tipo Juego no se puede abrir mas de 1 vez
                    this.ramUsada += app.RamRequerida;
                    Console.WriteLine($"Se abrio {app.Nombre} correctamente");
                    return true;
                }
            }
            Console.WriteLine("La aplicacion no esta instalada");
            return false;
        }

        public bool CerrarApp(App app)
        {
            if (app == null)
            {
                return false;
            }
            foreach (App aplicacion in this.aplicacionesActivas)
            {
                if (aplicacion.Nombre == app.Nombre)
                {
                    this.aplicacionesActivas.Remove(app);
                    this.ramUsada -= app.RamRequerida;
                    app.AplicacionActiva = false;
                    Console.WriteLine($"Se cerro {app.Nombre} correctamente");
                    return true;
                }
            }
            Console.WriteLine("La aplicacion no esta abierta");
            return false;
        }

        #endregion

        #region cosas
        
        public bool VerificarAppNull(App app)
        {
            if (app == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion


    }
}