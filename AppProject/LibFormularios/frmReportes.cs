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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Calificacion.TCalificada' Puede moverla o quitarla según sea necesario.
            this.TCalificadaTableAdapter.Fill(this.Calificacion.TCalificada);
            // TODO: esta línea de código carga datos en la tabla 'dbCepruDataSet.TErrores' Puede moverla o quitarla según sea necesario.
            this.TErroresTableAdapter.Fill(this.dbCepruDataSet.TErrores);

            this.reportViewer1.RefreshReport();
        }
    }
}
