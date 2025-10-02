namespace ConsolaDeVideojuegos
{
    internal class Program
    {
        static void Main(string[] args)
        { //posiblemente borrar todo
            do //cambiar el do while a while y cambiar la condicion
            {
                Console.Clear();
                ConsolaDeVideojuegos miConsola = null; // pensar que cambiar q clase ponen en vez de consola (pc o algun servicio de suscripcion de jugar en la nube)
                Console.WriteLine("--- Bienvenido al gestor de consolas ---");
                Console.WriteLine("1. Elegir PlayStation 5");
                Console.WriteLine("2. Elegir Xbox Series X");
                Console.WriteLine("3. Elegir Nintendo Switch");
                Console.WriteLine("4.salir");
                Console.Write("Elegir una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        miConsola = new ConsolaDeVideojuegos("Sony", "PlayStation 5", 825);
                        break;
                    case "2":
                        miConsola = new ConsolaDeVideojuegos("Microsoft", "Xbox Series X", 1000);
                        break;
                    case "3":
                        miConsola = new ConsolaDeVideojuegos("Nintendo", "Switch", 64);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");

                        return;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        Console.ReadKey();
                        continue;
                }
                if (miConsola != null)
                {
                    string opcionAccion;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine(miConsola.MostrarInfoConsola());
                        Console.WriteLine("--- Menu de Acciones ---");
                        Console.WriteLine("1. Instalar juego");
                        Console.WriteLine("2. Desintalar un juego");
                        Console.WriteLine("3. Mostrar biblioteca de juegos");
                        Console.WriteLine("4. Mostrar almacenamiento disponible");
                        Console.WriteLine("5. Salir");
                        Console.Write("Elegir una opción: ");
                        opcionAccion = Console.ReadLine();
                        switch (opcionAccion)
                        {
                            case "1":
                                Console.Write("Ingrese el nombre del juego a instalar: ");
                                string juegoInstalar = Console.ReadLine();
                                Console.Write("Ingrese el tamaño del juego en GB: ");
                                double tamañoInstalar = double.Parse(Console.ReadLine());
                                miConsola.InstalarJuego(juegoInstalar, tamañoInstalar);
                                Console.ReadKey();
                                break;
                            case "2":
                                Console.Write("Ingrese el nombre del juego a desintalar: ");
                                string juegoDesintalar = Console.ReadLine();
                                miConsola.DesintalarJuego(juegoDesintalar);
                                Console.ReadKey();
                                break;
                            case "3":
                                //string biblioteca = miConsola.MostrarBiblioteca();
                                //Console.WriteLine(biblioteca);
                                Console.WriteLine(miConsola.MostrarBiblioteca());
                                Console.ReadKey();
                                break;
                            case "4":
                                string almacenamientoDisponible = miConsola.GetAlmacenamientoDisponible().ToString();
                                Console.WriteLine($"Almacenamiento disponible: {almacenamientoDisponible} GB");
                                Console.ReadKey();
                                break;
                            case "5":
                                Console.WriteLine("Regresando al menú principal...");
                                Console.ReadKey();
                                break;
                            default:
                                Console.WriteLine("Opcion no valida, intente de nuevo.");
                                Console.ReadKey();
                                break;
                        }
                    } while (opcionAccion != "5");
                }
            } while (true);
        }
    }
}