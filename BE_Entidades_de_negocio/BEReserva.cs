using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Entidades_de_negocio
{
    internal class BEReserva
    {
        //PROPIEDADES
        public int IdReserva { get; set; }
        public DateTime Fecha { get; set; }
        public int CantComensales { get; set; }
        public Boolean Estado { get; set; }
        public BEMesa IdMesa { get; set; } //FK 
        public BEUsuario IdUsuario { get; set; } //FK tengo mis dudas si es necesario

        //CONSTRUCTOR
        public BEReserva() { }

        //CONSTRUCTOR CON PARAMETROS 
        public BEReserva(int idReserva, DateTime fecha, int cantComensales, Boolean estado, BEMesa idMesa, BEUsuario idUsuario)
        {
            IdReserva = idReserva;
            Fecha = fecha;
            CantComensales = cantComensales;
            Estado = estado;
            IdMesa = idMesa;
            IdUsuario = idUsuario;
        }


    }
}
