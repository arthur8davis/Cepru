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
    public partial class frmEscuela : frmPadre
    {
        //Atributos
        string nombre_direccion = "1. Escuelas.xls";
        string nombre_tabla = "TEscuela";


        public frmEscuela()
        {
            InitializeComponent();
            IniciarEntidad(new cEscuela());
        }
        //=================== REDEFINICION DE LOS METODOS VIRTUALES ==========================

        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { tbCarrera.Text, tbNombre.Text, tbGrupo.Text };
        }

        //---------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de CLibro
            tbNombre.Text = aEntidad.ValorAtributo("nombre");
            tbGrupo.Text = aEntidad.ValorAtributo("grupo");
        }

        //--------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            tbCarrera.Text = "";
        }
        public override void InicializarAtributoNoClave()
        {
            tbNombre.Text = "";
            tbGrupo.Text = "";
        }

        //--------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los libros de la tabla en el grid
            dgvEscuela.DataSource = aEntidad.ListaGeneral();
        }

        //------------------------------------------------------
        //--verificar los campos obligados(codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (tbCarrera.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            {
                return true;
            }
            else
                return false;
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                ConexionExcel(nombre_direccion, dgvEscuela);
                ConexionSql(nombre_tabla);
                MessageBox.Show("Datos importados");
            }
            catch (Exception)
            {

                MessageBox.Show("Datos ya importados ");
            }
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmEscuela_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void tbCarrera_TextChanged(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
