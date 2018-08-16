using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public abstract class cEntidad
    {
        //==============================ATRIBUTOS===============================
        private cConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null;  //-- nombres de los campos de la tabla
        string[] aValores = null; //-- valores de los campos de la tabla
        private bool aNuevo;

        //==============================METODOS===============================
        //------------------------------Constructor---------------------------
        public cEntidad(string pNombreTabla)
        {
            // Iniciar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new cConexion();
            aNombres = NombresAtributos();
        }

        //------------------------------Propiedades---------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }


        //--------------------Metodos de soporte de BD---------------------------
        //----------------------------------------------------------------------
        // Metodo abstracto encargado de establecer los nombres de los campos
        // (atributos) de la tabla. Se deben implementar necesariamente
        // en los herederos como arreglos de cadenas.
        // Estos atributos deben concidir con los existentes en la Base de Datos
        //----------------------------------------------------------------------
        public abstract string[] NombresAtributos();

        //----------------------------------------------------------------------
        // Metodos para el mantenimiento de la tabla
        //----------------------------------------------------------------------

        //--------------------Insercion de nuevos registros---------------------------
        public virtual void Insertar(params string[] Atributos)
        {
            // Permite insertar informacion de un registro en la tabla

            // Recuperar los valores de los atributos
            aValores = Atributos;
            // Formar la cadena de insercion
            string cadenaInsertar = "insert into " + aNombreTabla + " values ('";
            for (int i = 0; i < aValores.Length; i++)
            {
                // Incluir los atributos de consulta
                cadenaInsertar += aValores[i];
                if (i == aValores.Length - 1)
                    // Se concateno el ultimo atributo. Terminar la consulta
                    cadenaInsertar += "')";
                else // Dejar la consulta lista para el siguiente atributo
                    cadenaInsertar += "', '";
            }

            // Ejecutar la consulta para insertar el registro
            aConexion.EjecutarComando(cadenaInsertar);
            aNuevo = false;
        }

        //------------------------------Actualizacion de registros---------------------------
        public void Actualizar(params string[] Atributos)
        {
            // Permite actualizar la informacion de un registro de la tabla

            // Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            // Formar la cadena de actualizacion
            // Se asume que la clave principal es el primer atributo (Posicion CERO)
            string cadenaActualizar = "update " + aNombreTabla + " set ";
            for (int i = 0; i < aValores.Length; i++)
            {
                // Incluir los atributos en la consulta
                cadenaActualizar += aNombres[i] + "= '" + aValores[i];
                if (i == aValores.Length - 1)
                    // Se concateno el ultimo atributo. Terminar asignacion de valores
                    cadenaActualizar += "'";
                else // Dejar la consulta lista para el siguiente atributo
                    cadenaActualizar += "', ";
            }
            // Agregar a la consulta la clausula WHERE
            cadenaActualizar += " where " + aNombres[0] + " = '" + aValores[0] + "'";

            // Ejecutar la consulta para actualizar el registro
            aConexion.EjecutarComando(cadenaActualizar);
        }

        //------------------------------Eliminacion de un registros---------------------------
        public void Eliminar(params string[] Atributos)
        {
            // Permite eliminar un registro

            // Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            // Formar la cadena de eliminacion
            string cadenaEliminar = "delete from " + aNombreTabla + " where " + aNombres[0] + " = '" + aValores[0] + "'";

            // Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarComando(cadenaEliminar);
        }

        //----------------------------------------------------------------------
        public bool ExisteClavePrimaria(params string[] Atributos)
        {
            // Verifica si un registro especifico existe

            // Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            // Formar la consulta
            string cadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            // Ejecutar la consulta
            aConexion.EjecutarComando(cadenaConsulta);

            // Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }

        //----------------------------------------------------------------------
        public DataTable Registro(params string[] Atributos)
        {
            // Recupera la informacion de un registro

            // Recuperar los nombres y valores de los atributos de la tabla
            aNombres = NombresAtributos();
            aValores = Atributos;

            // Formar la consulta
            string cadenaConsulta = "select * from " + aNombreTabla + " where " + aNombres[0] + "= '" + aValores[0] + "'";

            // Ejecutar la consulta y devolver el resultado
            aConexion.EjecutarComando(cadenaConsulta);
            return aConexion.Datos.Tables[0];
        }

        //----------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {
            // Recupera el valor de un atributo del dataset
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }

        //----------------------------------------------------------------------
        public DataTable ListaGeneral()
        {
            // Retorna una tabla con la lista completa
            string consulta = "select * from " + aNombreTabla;
            aConexion.EjecutarSelect(consulta);
            return aConexion.Datos.Tables[0];
        }

    }
}
