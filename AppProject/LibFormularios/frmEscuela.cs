using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LibClases;

namespace LibFormularios
{
    public partial class frmEscuela : LibFormularios.frmPadre
    {
        

        public frmEscuela()
        {
            InitializeComponent();
           // IniciarEntidad(new cEscuela());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ImportarExcel();
            procesar();
        }

        private void procesar()
        {
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Carrera", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Grupo", typeof(string));

            string exp = @"[,\.\+\;]"; //Expresion regular
            if (dgvDatos.Columns.Count > 3)
            {
                for (int i = 0; i < dgvDatos.Rows.Count; i++)
                {
                    if (dgvDatos[0, i].Value.ToString().Length != 8)
                    { //Si el codigo del alumno no es 8
                        //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString());
                        dgvDatos.Rows.RemoveAt(i);
                    }
                    //Si los nombres de los alumnos una expresion de mas como ,;. y + o si el nombre esta vacio
                    else if (Regex.IsMatch(dgvDatos[1, i].Value.ToString(), exp) || dgvDatos[1, i].Value.ToString() == "")
                    {
                        dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), dgvDatos[6, i].Value.ToString(), dgvDatos[7, i].Value.ToString());
                        //dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dgvDatos.Rows.RemoveAt(i);
                    }
                }
            }
            dgvErrores.DataSource = dt;
            dgvErrores.AutoResizeColumns();
        }

        public override string NombreTabla()
        {
            string nombre = "TEscuelas";
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
            dt.Columns.Add("grupo", typeof(string));
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
