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

namespace AppProject
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
            
        }

        private void BtnEscuelas_Click(object sender, EventArgs e)
        {
            frmEscuela Escuelas = new frmEscuela();
            Escuelas.ShowDialog();
            CkbEscuelas.Checked = true;
            BtnPostulantes.Enabled = true;
            BtnCorreciones.Enabled = true;
            BtnEscuelas.Enabled = false;
            BtnPostulantes.Focus();
        }

        private void BtnPostulantes_Click(object sender, EventArgs e)
        {
            frmPostulantes postu = new frmPostulantes();
            postu.ShowDialog();
            CkbPostulantes.Checked = true;
            BtnFaltantes.Enabled = true;
            BtnPostulantes.Enabled = false;
            BtnFaltantes.Focus();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("INICE EL PROCESO CARGANDO LAS ESCUELAS");
        }

        private void BtnFaltantes_Click(object sender, EventArgs e)
        {
            frmFaltantes Faltas = new frmFaltantes();
            Faltas.ShowDialog();
            CkbFaltantes.Checked = true;
            BtnIdentidad.Enabled = true;
            BtnFaltantes.Enabled = false;
            BtnIdentidad.Focus();
        }

        private void BtnIdentidad_Click(object sender, EventArgs e)
        {
            frmIdentidad indenA = new frmIdentidad();
            if (CkbIdentidadA.Checked==false&& CkbIdentidadB.Checked == false&& CkbIdentidadC.Checked == false&& CkbIdentidadD.Checked == false)
            {
                indenA.ShowDialog();
                CkbIdentidadA.Checked = true;
            }
            else
            {
                if (CkbIdentidadA.Checked == true && CkbIdentidadB.Checked == false && CkbIdentidadC.Checked == false && CkbIdentidadD.Checked == false)
                 {
                    indenA.ShowDialog();
                    CkbIdentidadB.Checked = true;
                }
                else
                {
                    if (CkbIdentidadA.Checked == true && CkbIdentidadB.Checked == true && CkbIdentidadC.Checked == false && CkbIdentidadD.Checked == false)
                    {
                        indenA.ShowDialog();
                        CkbIdentidadC.Checked = true;
                    }
                    else
                    {
                        indenA.ShowDialog();
                        CkbIdentidadD.Checked = true;
                        BtnRespuestasAlumn.Enabled = true;
                        BtnIdentidad.Enabled = false;
                        BtnRespuestasAlumn.Focus();
                    }
                }
            }
            
        }

        private void BtnRespuestasAlumn_Click(object sender, EventArgs e)
        {
            frmRespuestasAlumnos indenA = new frmRespuestasAlumnos();
            if (CkbRespAlumnosA.Checked == false && CkbRespAlumnosB.Checked == false && CkbRespAlumnosC.Checked == false && CkbRespAlumnosD.Checked == false)
            {
                indenA.ShowDialog();
                CkbRespAlumnosA.Checked = true;
            }
            else
            {
                if (CkbRespAlumnosA.Checked == true && CkbRespAlumnosB.Checked == false && CkbRespAlumnosC.Checked == false && CkbRespAlumnosD.Checked == false)
                {
                    indenA.ShowDialog();
                    CkbRespAlumnosB.Checked = true;
                }
                else
                {
                    if (CkbRespAlumnosA.Checked == true && CkbRespAlumnosB.Checked == true && CkbRespAlumnosC.Checked == false && CkbRespAlumnosD.Checked == false)
                    {
                        indenA.ShowDialog();
                        CkbRespAlumnosC.Checked = true;
                    }
                    else
                    {
                        indenA.ShowDialog();
                        CkbRespAlumnosD.Checked = true;
                        BtnRespuestasAlumn.Enabled = false;
                        BtnClaveRespuestas.Enabled = true;
                        BtnClaveRespuestas.Focus();
                    }
                }
            }
        }

        private void BtnClaveRespuestas_Click(object sender, EventArgs e)
        {
            frmClaves claves = new frmClaves();
            claves.ShowDialog();
            CkbClaves.Checked = true;
            MessageBox.Show("CARGADO DE DATOS EXITOSO - PROCEDA A REALZIAR CORRECCIONES");
            BtnCorreciones.Enabled = true;
            BtnClaveRespuestas.Enabled = false;
        }

        private void BtnCorreciones_Click(object sender, EventArgs e)
        {
            frmCorrecciones Correcciones = new frmCorrecciones();
            Correcciones.ShowDialog();
            BtnCalificar.Enabled = true;
        }
    }
}
