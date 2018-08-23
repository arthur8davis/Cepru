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
    public partial class frmPostulantes : LibFormularios.frmPadre
    {
        public frmPostulantes()
        {
            InitializeComponent();
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
            dt.Columns.Add("Sexo", typeof(char));
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
                        dt.Rows.Add(dgvDatos[0, i].Value.ToString(), dgvDatos[1, i].Value.ToString(), dgvDatos[2, i].Value.ToString(), dgvDatos[3, i].Value.ToString(), dgvDatos[4, i].Value.ToString(), dgvDatos[5, i].Value.ToString(), dgvDatos[6, i].Value.ToString(), dgvDatos[7, i].Value.ToString());
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
    }
}
