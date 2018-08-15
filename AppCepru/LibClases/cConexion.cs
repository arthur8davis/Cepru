using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibClases
{
    public class cConexion
    {
        //==============================ATRIBUTOS===============================
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;

        //==============================METODOS===============================
        //------------------------------Constructor---------------------------
        public cConexion()
        {
            // Iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();

            // Realizar la conexion
            string cadenaConexion = "Data Source = .\\SQLEXPRESS; Initial Catalog=dbCepru; Integrated Security=SSPI;";
            aConexion = new SqlConnection(cadenaConexion);
        }

        //------------------------------Constructor---------------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }

        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }

        public DataSet Datos
        {
            get { return aDatos; }
        }

        //------------------------------Servicios---------------------------
        // Metodos para ejecutar comandos sql server
        // Devuelve el resultado en la tabla cero del dataset
        public virtual DataSet EjecutarSelect(string pConsulta)
        {
            // Metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }

        // Metodo para ejecutar instrucciones DML. No retorna resutado
        public virtual void EjecutarComando(string pComando)
        {
            // Metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
