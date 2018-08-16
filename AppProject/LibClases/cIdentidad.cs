using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cIdentidad: cEntidad
    {
        //================= ATRIBUTOS ===============
        //------ Todos heredados de cEntidad --------

        //=============== METODOS ===================
        //--------------Constructores ---------------
        public cIdentidad() : base("TIdentidad")
        {

        }

        //--- Implementacion de metodos abstractos ---
        public override string[] NombresAtributos()
        {
            return new string[] { };
        }

    }
}
