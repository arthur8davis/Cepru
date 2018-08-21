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
    public partial class frmRespuestasAlumnos : LibFormularios.frmPadre
    
    {
        public frmRespuestasAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarArchivoTxt();
        }

        private void Procesar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codido Tarjeta", typeof(string));
            dt.Columns.Add("Tema", typeof(string));
            dt.Columns.Add("Respuesta", typeof(string));

            
        }
    }
}
