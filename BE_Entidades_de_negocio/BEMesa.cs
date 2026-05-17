using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Entidades_de_Negocio
{
    public class BEMesa
    {
        //PROPIEDADES
        public int IdMesa { get; set; }
        public int Capacidad { get; set; }
        public EstadoMesa Estado { get; set; }

        //CONSTRUCTOR
        public BEMesa() { }

        //CONSTRUCTOR CON PARAMETROS
        public BEMesa(int idMesa, int capacidad, EstadoMesa estado)
        {
            IdMesa = idMesa;
            Capacidad = capacidad;
            Estado = estado;
        }

    }
}