using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;

namespace LibFormularios
{
    public partial class frmPostulantes : LibFormularios.frmPadre
    {
        SqlConnection cn;

        public frmPostulantes()
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
            ImportarExcel();
            Procesar();
        }

        private void Procesar()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Carrera", typeof(string));
            dt.Columns.Add("Ciclo", typeof(string));
            dt.Columns.Add("Aula Examen", typeof(string));
            dt.Columns.Add("Carpeta", typeof(string));
            dt.Columns.Add("Sexo", typeof(string));
            dt.Columns.Add("Grupo", typeof(char));
            
            string exp = @"[,\.\+\;]"; //Expresion regular
            if (dgvDatos.Columns.Count > 3)
            {
                for (int i = 0; i < dgvDatos.Rows.Count; i++)
                {
                    if (dgvDatos[0, i].Value.ToString().Length != 8)
                    { //Si el codigo del alumno no es 8
                        //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvDatos.Rows.RemoveAt(i);
                    }
                    //Si los nombres de los alumnos una expresion de mas como ,;. y + o si el nombre esta vacio
                    else if (Regex.IsMatch(dgvDatos[1, i].Value.ToString(), exp) || dgvDatos[1, i].Value.ToString() == "")
                    {

                        if (dgvDatos[6, i].Value.ToString() == "1")
                        {
                            dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Masculino", dgvDatos[7, i].Value.ToString());
                        }
                        else
                        {
                            dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Femenino", dgvDatos[7, i].Value.ToString());
                        }
                        //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvDatos.Rows.RemoveAt(i);
                    }
                }
            }
            dgvErrores.DataSource = dt;
            dgvErrores.AutoResizeColumns();

            if (dgvErrores.DataSource == null)
            {
                MessageBox.Show("no ha datos");
            }
        }

        public override string NombreTabla()
        {
            string nombre = "TPostulante";
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

            dt.Columns.Add("codigo", typeof(string));
            dt.Columns.Add("nombre", typeof(string));
            dt.Columns.Add("carrera", typeof(string));
            dt.Columns.Add("ciclo", typeof(string));
            dt.Columns.Add("aula", typeof(string));
            dt.Columns.Add("carpeta", typeof(string));
            dt.Columns.Add("sexo", typeof(string));
            dt.Columns.Add("grupo", typeof(string));
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                //dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), dgvDatos[6, i].Value.ToString(), dgvDatos[7, i].Value.ToString());
                if (dgvDatos[6, i].Value.ToString() == "1")
                {
                    dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Masculino", dgvDatos[7, i].Value.ToString());
                }
                else
                {
                    dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), "Femenino", dgvDatos[7, i].Value.ToString());
                }
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
                            + dgvErrores[0, i].Value.ToString() + "','"
                            + dgvErrores[1, i].Value.ToString() + "','"
                            + dgvErrores[2, i].Value.ToString() + "','"
                            + dgvErrores[3, i].Value.ToString() + "','"
                            + dgvErrores[4, i].Value.ToString() + "','"
                            + dgvErrores[5, i].Value.ToString() + "','"
                            + dgvErrores[6, i].Value.ToString() + "','"
                            + dgvErrores[7, i].Value.ToString() + "','"
                            + " ','"
                            + " ','"
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
