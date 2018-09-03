using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFormularios
{
    public partial class frmIdentidad : LibFormularios.frmPadre
    {
        public frmIdentidad()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivoTxt("Txt Files |*Identidad*.sdf");
            procesar();
        
        }

        private void procesar()
        {


            DataTable dte = new DataTable();
            dte.Columns.Add("Codigo de Tarjeta", typeof(string));
            dte.Columns.Add("Codigo de Postulante", typeof(string));

            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos[0,i].Value.ToString().Trim().Length != 6 || dgvDatos[1, i].Value.ToString().Trim().Length != 8 || dgvDatos[0, i].Value.ToString().Contains(" ") || dgvDatos[1, i].Value.ToString().Contains(" "))
                {
                    //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dte.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString());
                    dgvDatos.Rows.RemoveAt(i);
                }
            }
            

            dgvErrores.DataSource = dte;
            dgvErrores.AutoResizeColumns();


        }

        public override string NombreTabla()
        {
            string nombre = "TIdentidad";
            return nombre;
        }
        public override DataTable Tabla()
        {
            DataTable dt = CreateDataTable();
            dgvDatos.Columns.Clear();
            return dt;
        }

        private DataTable CreateDataTable()
        {
            // Creamos un nuevo objeto DataTable

            DataTable dt = new DataTable();

            dt.Columns.Add("CodTarjeta", typeof(string));
            dt.Columns.Add("CodAlumno", typeof(string));
            
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString());
            }

            return dt;
        }

        public override void Grabar()
        {
            base.Grabar();
        }

        public void grabarErrores()
        {
            /*
            using System.Configuration;
            variable global sqlconenecction cn;
            insertar el try catch dentro de la creacion
        
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
            } catch
            {

            }
            try
            {

                for{
                    SqlCommand cmd = new SqlCommand("sp_insertarEscuelas", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nom", dgv.rosbdak);
                    cmd.Parameters.AddWithValue("@edad", escuela.nombre);
                    cmd.Parameters.AddWithValue("@sexo", escuela.grupo);
                    if (cn.State == ConnectionState.Open) cn.Close();
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                  }    
            }
            catch (Exception n)
            {
                MessageBox.Show(n.ToString()/*"ERROR AL GUARDAR LOS DATOS");*/
        }
    }
}
