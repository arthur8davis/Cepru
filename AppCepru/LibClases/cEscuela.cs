using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cEscuela: cEntidad
    {
        //================= ATRIBUTOS ===============
        //------ Todos heredados de cEntidad --------

        //=============== METODOS ===================
        //--------------Constructores ---------------
        public cEscuela(): base("TEscuela")
        {

        }

        //--- Implementacion de metodos abstractos ---
        public override string[] NombresAtributos()
        {
            return new string[] { "codigo", "nombre", "grupo" };
        }
    }
}
