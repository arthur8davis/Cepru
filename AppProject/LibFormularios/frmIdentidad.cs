using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace LibFormularios
{
    public partial class frmIdentidad : LibFormularios.frmPadre
    {
        SqlConnection cn;
        public frmIdentidad()
        {
            InitializeComponent();
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
            }
            catch
            {


            }
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
            guardarErrores();
            base.Grabar();
        }

        private void guardarErrores()
        {
            if (dgvErrores.RowCount!=0)
            {
                try
                {
                    for (int i = 0; i < dgvErrores.RowCount; i++)
                    {
                        cn.Open();
                        //formar la cadena de insercion
                        string CadenaInsertar = "insert into TErrores values ('"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + dgvErrores[0, i].Value.ToString() + "','"
                            + dgvErrores[1, i].Value.ToString() + "','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ','"
                            + " ',' "
                            + "')";
                        //Insertar el registro
                        SqlCommand oComando = new SqlCommand(CadenaInsertar, cn);
                        oComando.ExecuteNonQuery();
                        cn.Close();
                    }

                }
                catch (Exception n)
                {

                    MessageBox.Show(n.ToString());
                }
            }
            
        }
    }
}
