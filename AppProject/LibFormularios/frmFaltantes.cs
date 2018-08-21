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
    public partial class frmFaltantes : LibFormularios.frmPadre
    {
        public frmFaltantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivoTxt();
            procesar();

        }

        private void procesar()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            
            for (int i = 0; i < dgvDatos.Rows.Count; i++)
                {
                    if (dgvDatos[0, i].Value.ToString().Trim().Length != 8)
                    { //Si el codigo del alumno no es 8
                        dgvDatos.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        dt.Rows.Add(dgvDatos[0, i].Value.ToString());
                    }
                    
                }
            dgvErrores.DataSource = dt;
            dgvErrores.AutoResizeColumns();
        }
    }
}
