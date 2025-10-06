namespace Desafio_CrearTuClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aplicaciones

            App Silksong = new App("Silksong", 7.6, 1.7, EnumApp.Juego, 6.99);
            App ShadowOfWar = new App("Middle-earth: Shadow of War", 109.6, 3.9, EnumApp.Juego, 59.99);
            App AgeOfEmpiresII = new App("Age of Empires II", 15.2, 4, EnumApp.Juego, 19.99);
            App MortalKombatX = new App("Mortal Kombat X", 43.2, 3.1, EnumApp.Juego, 15);
            App MicrosoftEdge = new App("Microsoft Edge", 0.5, 2.2, EnumApp.Navegador);
            App Discord = new App("Discord", 0.1, 0.7, EnumApp.RedSocial);
            App VisualStudio2022 = new App("Visual Studio 2022", 3.7, 2.1, EnumApp.Herramienta);
            App WallpaperEngine = new App("Wallpaper Engine", 0.6, 0.3, EnumApp.Personalizacion, 2.99);

            #endregion

            PC pc1 = new PC("R57600", 32, 1000);
            Console.WriteLine(pc1.MostrarInfo());
            pc1.InstalarApp(Silksong);
            pc1.InstalarApp(MortalKombatX);
            pc1.InstalarApp(Discord);
            pc1.InstalarApp(MicrosoftEdge);
            pc1.InstalarApp(WallpaperEngine);
            //Console.WriteLine(pc1.AdministradorDeAlmacenamiento());
            pc1.AbrirApp(Silksong);
            pc1.AbrirApp(Silksong);
            Console.WriteLine(pc1.MostrarInfo());


            #region interfaz - mas o menos 

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


        }
    }
}
