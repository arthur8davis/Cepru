using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    public class cPostulante : cEntidad
    {
        //================= ATRIBUTOS ===============
        //------ Todos heredados de cEntidad --------

        //=============== METODOS ===================
        //--------------Constructores ---------------
        public cPostulante(): base("TPostulante")
        {

        }

        //--- Implementacion de metodos abstractos ---
        public override string[] NombresAtributos()
        {
            return new string[] { "codigo", "nombre", "carrera", "ciclo", "aula", "carpeta", "sexo", "grupo" };
        }

    }
}
