using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurbeteriaCasa.Dtos
{
    /// <summary>
    /// Clase que representa a la entidad cuberteria
    /// </summary>
    internal class CuberteriaDto
    {
        //ATRIBUTOS

        long idCuberteria;
        int platosHondos = 11111;
        int platosLlanos = 11111;
        int tenedores = 11111;
        int cucharas = 11111;
        int cuchillos =11111;

        //CONSTRUCTORES
        public CuberteriaDto(long idCuberteria, int platosHondos, int platosLlanos, int tenedores, int cucharas, int cuchillos)
        {
            this.idCuberteria = idCuberteria;
            this.platosHondos = platosHondos;
            this.platosLlanos = platosLlanos;
            this.tenedores = tenedores;
            this.cucharas = cucharas;
            this.cuchillos = cuchillos;
        }

        public CuberteriaDto() { }  


        //GETTERS & SETTERS
        public long IdCuberteria { get => idCuberteria; set => idCuberteria = value; }
        public int PlatosHondos { get => platosHondos; set => platosHondos = value; }
        public int PlatosLlanos { get => platosLlanos; set => platosLlanos = value; }
        public int Tenedores { get => tenedores; set => tenedores = value; }
        public int Cucharas { get => cucharas; set => cucharas = value; }
        public int Cuchillos { get => cuchillos; set => cuchillos = value; }

        //TO STRING
        public string ToString()
        {
            string cuberteriaString = " -- ID:" + this.idCuberteria + 
            " |Platos Hondos: " + this.platosHondos + 
            " |Platos Llanos: " + this.platosLlanos +
            " |Tenedores:" + this.tenedores +
            " |Cucharas: " + this.cucharas + 
            " |Cuchillos: " + this.cuchillos;
            return cuberteriaString;    

        }

    }

}
