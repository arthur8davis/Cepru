using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cFaltante: cEntidad
    {
        //================= ATRIBUTOS ===============
        //------ Todos heredados de cEntidad --------

        //=============== METODOS ===================
        //--------------Constructores ---------------
        public cFaltante() : base("TFaltante")
        {

        }

        //--- Implementacion de metodos abstractos ---
        public override string[] NombresAtributos()
        {
            return new string[] { };
        }

    }
}
