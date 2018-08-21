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
            CargarArchivoTxt();

        
        }

        private void procesar()
        {

        }
    }
}
