using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaDeVideojuegos
{
    public class ConsolaDeVideojuegos
    {
        #region atributos
        private string marca;
        private string modelo;
        private double almacenamientoTotal;
        private double almacenamientoDisponible;
        private List<string> juegosInstalados;
        private List<double> tamañoJuegos;
        #endregion

        #region constructor
        public ConsolaDeVideojuegos(string marca, string modelo, double almacenamientoTotal)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.almacenamientoTotal = almacenamientoTotal;
            this.almacenamientoDisponible = almacenamientoTotal;
            this.juegosInstalados = new List<string>();
            this.tamañoJuegos = new List<double>();
        }
        #endregion


        #region metodos
        public string MostrarInfoConsola()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("Marca: " + this.marca);
            mensaje.AppendLine("Modelo: " + this.modelo);
            mensaje.AppendLine("Almacenamiento Total: " + this.almacenamientoTotal + " GB");
            return mensaje.ToString();
        }

        public bool InstalarJuego(string nombreJuego, double tamañoGB)
        {
            if (this.almacenamientoDisponible > tamañoGB)
            {
                this.juegosInstalados.Add(nombreJuego);
                this.tamañoJuegos.Add(tamañoGB);
                this.almacenamientoDisponible -= tamañoGB;
                Console.WriteLine($"Juego '{nombreJuego}' instalado.");
                return true;
            }
            else
            {
                Console.WriteLine($"Error: no hay espacio suficiente. Se requiere {tamañoGB}GB y el espacio disponible es de {this.almacenamientoDisponible}GB");
                return false;
            }
        }

        public bool DesintalarJuego(string nombreJuego)
        {
            for (int i = 0; i < this.juegosInstalados.Count; i++)
            {
                if (this.juegosInstalados[i] == nombreJuego)
                {
                    double tamañoGB = this.tamañoJuegos[i];
                    this.almacenamientoDisponible += tamañoGB;
                    this.juegosInstalados.RemoveAt(i);
                    this.tamañoJuegos.RemoveAt(i);
                    Console.WriteLine($"{nombreJuego} desintalado");
                    return true;
                }
            }
            Console.WriteLine($"Error: el juego {nombreJuego} no existe en la biblioteca.");
            return false;
        }

        public string MostrarBiblioteca()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine("--- Mi Biblioteca de juego ---");
            if (this.juegosInstalados.Count == 0)
            {
                mensaje.AppendLine("No hay juegos instalados.");
            }
            else
            {
                for (int i = 0; i < this.juegosInstalados.Count; i++)
                {
                    mensaje.AppendLine($"{i + 1}. {this.juegosInstalados[i]}");
                }
            }
            return mensaje.ToString();
        }
        #endregion


        #region getters y setters
        public double GetAlmacenamientoDisponible()
        {
            return this.almacenamientoDisponible;
        }
        #endregion




    }
}