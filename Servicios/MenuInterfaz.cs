using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurbeteriaCasa.Servicios
{
    /// <summary>
    /// Interfaz con la relacion de métodos  de la funcionalidad menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra y recoge la opcion del menu principal
        /// </summary>
        /// <returns></returns>
        public int MostrarMenuYSeleccion();
        /// <summary>
        /// Método que muestra y recoge la opcion modificar cuberteria
        /// </summary>
        /// <returns></returns>
        public int MenuModificarCuberteria();
    }
}
