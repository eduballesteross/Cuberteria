using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurbeteriaCasa.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MenuModificarCuberteria()
        {
            int opcion;

            Console.WriteLine("##################");
            Console.WriteLine("0- Salir del Menu");
            Console.WriteLine("1- Platos Hondos");
            Console.WriteLine("2- Platos LLanos");
            Console.WriteLine("3- Tenedores");
            Console.WriteLine("4- Cucharas");
            Console.WriteLine("5- Cuchillos");
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("##################");
            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;  
        }

        public int MostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("###########################");
            Console.WriteLine("0- Salir de la aplicación.");
            Console.WriteLine("1- Dar de alta Cubertería.");
            Console.WriteLine("2- Modificar cubertería.  ");
            Console.WriteLine("3- Eliminar cuberteria.");
            Console.WriteLine("4- Eliminar un campo concreto.");
            Console.WriteLine("5- Historial de operaciones.");
            Console.WriteLine("Seleccione una opcion.");
            Console.WriteLine("###########################");
            opcion=Console.ReadKey(true).KeyChar - ('0');

            return opcion;  

        }

        
    }
}
