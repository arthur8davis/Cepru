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
            IniciarEntidad(new cEscuela());
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
        //=================== REDEFINICION DE LOS METODOS VIRTUALES ==========================

        //-- Establecer los valores que iran a la tabla
        /*public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodLibro.Text, TxtTitulo.Text, TxtAutor.Text, TxtEditorial.Text, TxtAnio.Text };
        }

        //---------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de CLibro
            TxtTitulo.Text = aEntidad.ValorAtributo("Titulo");
            TxtAutor.Text = aEntidad.ValorAtributo("Autor");
            TxtEditorial.Text = aEntidad.ValorAtributo("Editorial");
            TxtAnio.Text = aEntidad.ValorAtributo("Anio");
        }

        //--------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodLibro.Text = "";
        }
        public override void InicializarAtributoNoClave()
        {
            TxtTitulo.Text = "";
            TxtAutor.Text = "";
            TxtEditorial.Text = "";
            TxtAnio.Text = "";
        }

        //--------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los libros de la tabla en el grid
            DgvLibros.DataSource = aEntidad.ListaGeneral();
        }

        //------------------------------------------------------
        //--verificar los campos obligados(codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (TxtCodLibro.Text.Trim() != "" && TxtTitulo.Text.Trim() != "")
            {
                return true;
            }
            else
                return false;
        }

        private void TxtCodLibro_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void frmLibro_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }*/
    }
}
