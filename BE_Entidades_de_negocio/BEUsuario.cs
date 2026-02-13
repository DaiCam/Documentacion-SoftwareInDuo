using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Entidades_de_negocio
{
    internal class BEUsuario
    {
        //PROPIEDADES
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public Boolean Activo { get; set; }

        //CONSTRUCTOR
        public BEUsuario() { }

        //CONSTRUCTOR CON PARAMETROS 
        public BEUsuario(int idUsuario, string nombre, string apellido, string email, string contraseña, bool activo)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contraseña = contraseña;
            Activo = activo;
        }
    }

}
