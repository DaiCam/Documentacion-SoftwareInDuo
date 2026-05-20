using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Entidades_de_Negocio;

namespace BLL_Reglas_de_Negocio
{
    public class BLLMesa
    {
        //necesito simular base de datos es por eso que voy a instanciar una mesa, y hardcodearle los datos.
        List<BEMesa> listaDeMesas;
        public BLLMesa() {
            listaDeMesas = new List<BEMesa>();

            listaDeMesas.Add(new BEMesa(1, 4, EstadoMesa.Ocupada));
            listaDeMesas.Add(new BEMesa(2, 3, EstadoMesa.Libre));
            listaDeMesas.Add(new BEMesa(3, 2, EstadoMesa.Reservada));
        }

        public List<BEMesa> listarMesas()
        {
            return listaDeMesas;
        }

        
        
    }
}
