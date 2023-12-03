using CurbeteriaCasa.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurbeteriaCasa.Servicios
{
    /// <summary>
    /// Interfaz con la relacion de métodos del ente CuberteriaDto
    /// </summary>
    internal interface CuberteriaInterfaz
    {
        /// <summary>
        /// Método que sirve para dar de alta una nueva Cuberteria
        /// </summary>
        /// <param name="listaCuberteria"></param>
        public void darAltaCuberteria(List<CuberteriaDto>listaCuberteria);
        /// <summary>
        /// Método que sirve para modificar algun campo de la lista cuberteria
        /// </summary>
        /// <param name="listaCuberteria"></param>
        public void modificarCuberteria(List<CuberteriaDto> listaCuberteria);
        
        /// <summary>
        ///Método que sirve para eliminar una cuberteria 
        /// </summary>
        /// <param name="listaCuberteria"></param>
        public void eliminarCuberteria(List<CuberteriaDto> listaCuberteria);

        

        /// <summary>
        /// Método que sirve para modificar un campo o eliminar una cuberteria mediante la comparacion de ID´s
        /// </summary>
        /// <returns></returns>
        public long BuscarID();
    }
}
