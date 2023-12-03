using CurbeteriaCasa.Dtos;
using CurbeteriaCasa.Servicios;

namespace CurberteriaCasa
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author>ebp - 031223</author>
    /// </summary>
    internal class Program
    {

        /// <summary>
        /// Método principal de la aplicación
        /// </summary>
        /// <param name="args"></param>

        public static void Main(string[] args)
        {

            List<CuberteriaDto> listaCuberteria = new List<CuberteriaDto>();

            MenuInterfaz menuI = new MenuImplementacion();
            CuberteriaInterfaz cuberI = new CuberteriaImplementacion();   

            int opcion;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcion = menuI.MostrarMenuYSeleccion();
                Console.WriteLine(opcion);
                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará el menu.");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO] Has seleccionado la opcion de dar de alta cubertería.");
                        cuberI.darAltaCuberteria(listaCuberteria);
                        break;

                    case 2:
                        Console.WriteLine("[INFO] Has seleccionado la opcion de modificar la cubertería.");
                        cuberI.modificarCuberteria(listaCuberteria);
                        break;

                    case 3:
                        Console.WriteLine("Has seleccionado la opcion de borrar una cuberteria");
                        cuberI.eliminarCuberteria(listaCuberteria);

                        break;

                    case 4:

                        break;

                    case 5:
                        foreach(CuberteriaDto cuberteria in listaCuberteria) 
                        {
                            Console.WriteLine(cuberteria.ToString());   
                        }
                        break;

                    default: Console.WriteLine("Has introducido una opcion incorrecta. Intentelo de nuevo");
                        break;
                }
            }

        }
    }
}
