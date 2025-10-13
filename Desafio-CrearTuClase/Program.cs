using System.ComponentModel.Design;

namespace Desafio_CrearTuClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aplicaciones

            //App Silksong = new App("Silksong", 7.6, 1.7, EnumApp.Juego, 6.99);
            //App ShadowOfWar = new App("Middle-earth: Shadow of War", 109.6, 3.9, EnumApp.Juego, 59.99);
            //App AgeOfEmpiresII = new App("Age of Empires II", 15.2, 4, EnumApp.Juego, 19.99);
            //App MortalKombatX = new App("Mortal Kombat X", 43.2, 3.1, EnumApp.Juego, 15);
            //App MicrosoftEdge = new App("Microsoft Edge", 0.5, 2.2, EnumApp.Navegador);
            //App Discord = new App("Discord", 0.1, 0.7, EnumApp.RedSocial);
            //App VisualStudio2022 = new App("Visual Studio 2022", 3.7, 2.1, EnumApp.Herramienta);
            //App WallpaperEngine = new App("Wallpaper Engine", 0.6, 0.3, EnumApp.Personalizacion, 2.99);

            #endregion


            #region idea de interfaz - mas o menos 

            //bienvendo
            //    eleji una pc
            //    armar pc

            //menu:
            //ver info
            //    instalar app
            //    desintalar app
            //    ver almacenamiento
            //    abrir app
            //        si abre steam
            //            ya puede abrir los juegos o cuando abre un juego verificar que tenga steam
            //            cargar saldo
            //            ver biblioteca
            //            ver tienda ?? -talvez poner todo lo q sea instalar y desintalar un tipo Juego aca
            //        si abre microsoft edge
            //            abrir pestaña -cada pestaña abierta aumentara la ram que consume la clase app
            //            cerrar pestaña
            //        si abre netflix
            //            contratar un de los distintos niveles de membresias
            //    cerrar app

            #endregion

            #region interfaz
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a su PC, eliga una opcion: ");
                Console.WriteLine("1. Procesador: Intel I5 12600k, Ram: 8GB, Almacenamiento: 250GB");
                Console.WriteLine("2. Procesador: Amd R7 8700G, Ram: 16GB, Almacenamiento: 500GB ");
                Console.WriteLine("3. Procesador: Amd R7 7700x, Ram: 32GB, Almacenamiento: 1024GB");
                Console.WriteLine("4. Arma tu PC: ");
                Console.WriteLine("5.Salir");
                string eleccionPC = Console.ReadLine();
                PC miPC = null;
                switch (eleccionPC)
                {
                    case "1":
                        miPC = new PC();
                        //utilizar los metodos set para modificar un estado de alguno de los objetos
                        miPC.Procesador = "Intel I5 12600k";
                        miPC.Ram = 8;
                        miPC.AlmacenamientoTotal = 250;
                        Console.WriteLine("PC armada");
                        Console.ReadKey();
                        break;
                    case "2":
                        miPC = new PC("Amd R7 8700G", 16);
                        miPC.AlmacenamientoTotal = 500;
                        Console.WriteLine("PC armada");
                        Console.ReadKey();
                        break;
                    case "3":
                        miPC = new PC("Amd R7 7700x", 32, 1024);
                        Console.WriteLine("PC armada");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("Ingrese el procesador que desea: ");
                        miPC = new PC();
                        miPC.Procesador = Console.ReadLine(); //validar
                        Console.Write("Ingrese la cantidad de ram que desea: ");
                        miPC.Ram = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de almacenamiento que desea: ");
                        miPC.AlmacenamientoTotal = double.Parse(Console.ReadLine());
                        Console.WriteLine("PC armada");
                        Console.ReadKey();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                }

                bool menu = (miPC != null);
                while (menu)
                {
                    Console.Clear();
                    Console.WriteLine("Usted esta en el Menu Princial: ");
                    Console.WriteLine("1. Ver info");
                    Console.WriteLine("2. Instalar App");
                    Console.WriteLine("3. Desintalar App");
                    Console.WriteLine("4. Ver almacenamiento");
                    Console.WriteLine("5. Abrir App");
                    Console.WriteLine("6. Cerrar App");
                    Console.WriteLine("7. Salir del menu");
                    string eleccionMenu = Console.ReadLine();
                    switch (eleccionMenu)
                    {
                        case "1":
                            //llamar a los metodos propios de cada objeto y mostrar los resultados de sus acciones en la consola
                            Console.WriteLine(miPC.MostrarInfo());
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Write("Nombre de la app: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Tamaño de la app (GB): ");
                            double tamanio = double.Parse(Console.ReadLine());
                            Console.Write("Ram requerida de la app (GB): ");
                            double ramRequerida = double.Parse(Console.ReadLine());
                            Console.WriteLine("Tipo de app: ");
                            Console.WriteLine("""
                                1. Juego
                                2. Red Social
                                3. Herramienta
                                4. Multimedia
                                5. Personalizacion
                                6. Navegador
                                7. Otro
                                """);
                            //crear por lo menos 2 objetos (instancia) diferentes de su clase
                            //incorporar un enumerado (enum): para gestionar un conjunto de opciones predefenidas y validar la entrada de usuario
                            //falta validar
                            App app = new App(nombre, tamanio, ramRequerida);
                            string eleccionNumericaTipo = Console.ReadLine();
                            switch (eleccionNumericaTipo)
                            {
                                case "1":
                                    app.Tipo = EnumApp.Juego;
                                    break;
                                case "2":
                                    app.Tipo = EnumApp.RedSocial;
                                    break;
                                case "3":
                                    app.Tipo = EnumApp.Herramienta;
                                    break;
                                case "4":
                                    app.Tipo = EnumApp.Multimedia;
                                    break;
                                case "5":
                                    app.Tipo = EnumApp.Personalizacion;
                                    break;
                                case "6":
                                    app.Tipo = EnumApp.Navegador;
                                    break;
                                case "7":
                                    app.Tipo = EnumApp.Otro;
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida, se asignara el tipo Otro");
                                    app.Tipo = EnumApp.Otro;
                                    break;
                            }
                            miPC.InstalarApp(app);
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Write("Ingrese el nombre de la app que desea desintalar: ");
                            string nombreDesintalar = Console.ReadLine();
                            miPC.DesintalarApp(nombreDesintalar);
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.WriteLine(miPC.AdministradorDeAlmacenamiento());
                            Console.ReadKey();
                            break;
                        case "5":
                            //Console.Write("Ingrese el nombre de la app que desea abrir: ");
                            //string nombreAbrir = App.Parse(Console.ReadLine());
                            //miPC.AbrirApp(nombreAbrir);
                            //Console.ReadKey();
                            //break;

                        default:
                            Console.WriteLine("Opcion invalida");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            #endregion



        }
    }
}