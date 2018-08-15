using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;

namespace frmPrincipal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscuela a = new frmEscuela();
            a.ShowDialog();

        }

        private void postulanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPostulante a = new frmPostulante();
            a.ShowDialog();
        }
    }
}
