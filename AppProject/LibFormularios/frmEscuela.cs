using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
