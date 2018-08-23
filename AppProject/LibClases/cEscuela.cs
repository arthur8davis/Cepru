using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LibClases
{
    public class cEscuela
    {
        /// <summary>
        /// conexion con el app.config
        /// </summary>
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        //================= ATRIBUTOS ===============
        //------ Todos heredados de cEntidad --------
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string grupo { get; set; }


        //=============== METODOS ===================
        //--------------Constructores ---------------

        public DataTable listado()
        {
            // procedimiento almacenado
            SqlCommand cmd = new SqlCommand("sp_listarEscuelas", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void insertar(cEscuela escuela)
        {
            SqlCommand cmd = new SqlCommand("sp_insertarEscuelas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nom", escuela.codigo);
            cmd.Parameters.AddWithValue("@edad", escuela.nombre);
            cmd.Parameters.AddWithValue("@sexo", escuela.grupo);
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();

        }

        public void eliminar(string cod)
        {
            SqlCommand cmd = new SqlCommand("sp_eliminarEscuelas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", cod);
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void editar(cEscuela escuela)
        {
            SqlCommand cmd = new SqlCommand("sp_editarEscuelas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@cod", escuela.codigo);
            cmd.Parameters.AddWithValue("@nom", escuela.nombre);
            cmd.Parameters.AddWithValue("@edad", escuela.grupo);

            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }


    }
}
