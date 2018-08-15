using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace LibClases
{
    public class cConexionExcel
    {
        //******************* ATRIBUTOS ****************
        private OleDbConnection origen = default(OleDbConnection);
        private DataSet aDatos;
        private OleDbDataAdapter adaptador;
        private OleDbCommand seleccion = default(OleDbCommand);
        SqlConnection conexion_destino;
        
        public void ConexionExcel(string aNombreExcel)
        {
            //iniciar la conexion
            aDatos = new DataSet();
            adaptador = new OleDbDataAdapter();
            // realizar la conexion
            string CadenaConexion = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=C:\\Users\\Admin\\Documents\\Labo 5\\Datos Simulados CEPRU\\" + aNombreExcel + ";Extended Properties=\"Excel 8.0; HDR=Yes\"";
            origen = new OleDbConnection(CadenaConexion);
            seleccion = new OleDbCommand("Select * From [Hoja1$]", origen);

            //adaptador.SelectCommand = seleccion;
            //adaptador.Fill(aDatos);
        }
        // --------- propiedades ---------------
        public OleDbConnection Origen 
        {
            get { return origen; }
        }
        public OleDbDataAdapter Adaptador
        {
            get { return adaptador; }
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        public OleDbCommand Seleccion
        {
            get { return seleccion; }
        }


        // *****************  SERVICIOS *********************
        // metodos para ejecutar comandos sql server
        // ---- devuelve el resultado la tabla cero del dataset
        public virtual DataSet EjecutarSelect()
        {
            //metodo para jecutar consulta del tipo select
            adaptador.SelectCommand = seleccion;
            aDatos = new DataSet();
            adaptador.Fill(aDatos);
            return aDatos;
        }

        public void ConexionSql(string nombreTabla)
        {
            origen.Close();
            conexion_destino = new SqlConnection();
            conexion_destino.ConnectionString = "Data Source= .;Initial Catalog=bdCepru; Integrated Security = True";

            conexion_destino.Open();

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(conexion_destino);
            importar.DestinationTableName = ""+ nombreTabla+"";
            importar.WriteToServer(aDatos.Tables[0]);
            conexion_destino.Close();
        }
            
            //dataGridView1.DataSource = aDatos.Tables[0];
            
        
    }
}
