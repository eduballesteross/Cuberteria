using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CurbeteriaCasa.Dtos;
using CurbeteriaCasa.Servicios;

namespace CurbeteriaCasa.Servicios
{

    /// <summary>
    /// Clase que implementa a la interfaz CuberteriaInterfaz
    /// <author>ebp - 031223</author>
    /// </summary>

    internal class CuberteriaImplementacion : CuberteriaInterfaz
    {
        public long BuscarID()
        {
            long id;
            Console.WriteLine("Introduzca el ID para buscarlo en la base de datos para poder realizar la opcion deseada");
            id = Convert.ToInt64(Console.ReadLine());
            return id;
        }

        public void darAltaCuberteria(List<CuberteriaDto> listaCuberteria)
        {
            CuberteriaDto nuevacuberteria = NuevaCuberteria();
            listaCuberteria.Add(nuevacuberteria);    
        }

        public void eliminarCuberteria(List<CuberteriaDto> listaCuberteria)
        {
            CuberteriaDto eliminarcuberteria =new CuberteriaDto();
            long idABuscar;
            idABuscar=BuscarID();   

            foreach (CuberteriaDto cuberteria in listaCuberteria)
            {
                if (cuberteria.IdCuberteria.Equals(idABuscar))
                {
                    Console.WriteLine("Se eliminará la cuberteria con el ID asociado");
                    eliminarcuberteria=cuberteria;
                    break;
                }  
            }
            listaCuberteria.Remove(eliminarcuberteria);
        }

        public void modificarCuberteria(List<CuberteriaDto> listaCuberteria)
        {
            
            MenuInterfaz menuI = new MenuImplementacion();  

            long idABuscar;
            idABuscar = BuscarID();

            foreach (CuberteriaDto cuberteria in listaCuberteria)
            {
                if (cuberteria.IdCuberteria.Equals(idABuscar))
                {
                    int opcion;
                    bool cerrarMenu = false;

                    

                    while(!cerrarMenu) 
                    {
                        opcion = menuI.MenuModificarCuberteria();
                        Console.WriteLine(opcion);

                        switch(opcion)
                        {
                            case 0:
                                Console.WriteLine("Has seleccionado la opcion cerrar Menu;");
                                cerrarMenu=true;    
                                break;

                            case 1:
                                Console.WriteLine("* Has seleccionado la opcion de modificar el número de platos hondos");
                                int platoshondos;
                                Console.WriteLine("Introduzca el nuevo número de platos hondos");
                                platoshondos=Convert.ToInt32(Console.ReadLine());
                                cuberteria.PlatosHondos = platoshondos;
                                break;

                            case 2:
                                Console.WriteLine("* Has seleccionado la opcion de modificar el número de platos llanos");
                                int platosllanos;
                                Console.WriteLine("Introduzca el nuevo número de platos llanos");
                                platosllanos = Convert.ToInt32(Console.ReadLine());
                                cuberteria.PlatosLlanos = platosllanos;
                                break;
                        }
                    }
                }
            }
           
        }

        private CuberteriaDto NuevaCuberteria()
        {
            CuberteriaDto nuevaCuberteria = new CuberteriaDto();    

            Console.WriteLine("Introduzca el ID:");
            nuevaCuberteria.IdCuberteria=Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el número de platos hondos");
            nuevaCuberteria.PlatosHondos= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el número de platos llanos");
            nuevaCuberteria.PlatosLlanos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el número de tenedores");
            nuevaCuberteria.Tenedores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el número de cucharas");
            nuevaCuberteria.Cucharas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el número de platos cuchillos");
            nuevaCuberteria.Cuchillos = Convert.ToInt32(Console.ReadLine());

            return nuevaCuberteria; 
        }
    }
}
