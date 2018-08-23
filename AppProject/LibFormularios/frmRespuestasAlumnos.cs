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

namespace LibFormularios
{
    public partial class frmRespuestasAlumnos : LibFormularios.frmPadre
    
    {
        public frmRespuestasAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivoTxt();
            Procesar();
        }

        private void Procesar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codido Tarjeta", typeof(string));
            dt.Columns.Add("Tema", typeof(string));
            dt.Columns.Add("Respuesta", typeof(string));
            string exp = @"[,\.\+\;\*\' ']"; //Expresion regular
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                if (dgvDatos[0, i].Value.ToString().Trim().Length != 6 || dgvDatos[1, i].Value.ToString().Trim().Length != 1 /*|| dgvDatos[0, i].Value.ToString().Contains(" ") || dgvDatos[1, i].Value.ToString().Contains(" ")*/ || (Regex.IsMatch(dgvDatos[0, i].Value.ToString(), exp))|| (Regex.IsMatch(dgvDatos[1, i].Value.ToString(), exp)))
                {
                    //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString());
                    dgvDatos.Rows.RemoveAt(i);
                }
            }

            dgvErrores.DataSource = dt;
            dgvErrores.AutoResizeColumns();
        }

        public override string NombreTabla()
        {
            string nombre = "TRespuesta";
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
            dt.Columns.Add("Tema", typeof(string));
            dt.Columns.Add("Respuestas", typeof(string));
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
            {
                dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString());
            }

            return dt;
        }

        public override void Grabar()
        {
            base.Grabar();
        }
    }
}
