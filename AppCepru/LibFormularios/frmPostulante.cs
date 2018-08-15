using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibClases;

namespace LibFormularios
{
    public partial class frmPostulante : frmPadre
    {
        //Atributos
        string nombre_direccion = "2. Postulantes.xls";
        string nombre_tabla = "TPostulante";

        public frmPostulante()
        {
            InitializeComponent();
            IniciarEntidad(new cPostulante());
        }
        //=================== REDEFINICION DE LOS METODOS VIRTUALES ==========================

        //-- Establecer los valores que iran a la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { tbCodigo.Text, tbNombre.Text, tbcarrera.Text, tbCiclo.Text, tbAula.Text, tbCarpeta.Text, tbSexo.Text, tbGrupo.Text };
        }

        //---------------------------------------------------------------
        //-- Mostrar los datos de un registro
        public override void MostrarDatos()
        {   //-- muestra la informacion contenida en el dataset de CLibro
            tbNombre.Text = aEntidad.ValorAtributo("nombre");
            tbcarrera.Text = aEntidad.ValorAtributo("carrera");
            tbCiclo.Text = aEntidad.ValorAtributo("ciclo");
            tbAula.Text = aEntidad.ValorAtributo("aulaexamen");
            tbCarpeta.Text = aEntidad.ValorAtributo("carpeta");
            tbSexo.Text = aEntidad.ValorAtributo("sexo");
            tbGrupo.Text = aEntidad.ValorAtributo("grupo");


        }
    

        //--------------------------------------------------------
        //-- Iniciar los atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            tbCodigo.Text = "";
        }
        public override void InicializarAtributoNoClave()
        {
            tbNombre.Text = "";
            tbcarrera.Text = "";
        }

        //--------------------------------------------------------
        //-- Listar los registros y mostrarlos en el datagrid
        public override void ListarRegistros()
        {   //-- Mostrar todos los libros de la tabla en el grid
            dgvPostulante.DataSource = aEntidad.ListaGeneral();
        }

        //------------------------------------------------------
        //--verificar los campos obligados(codigo y titulo) esten llenos
        public override bool EsRegistroValido()
        {
            if (tbCodigo.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            {
                return true;
            }
            else
                return false;
        }

        private void btImportar_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                ConexionExcel(nombre_direccion, dgvPostulante);
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

        private void frmPostulante_Load(object sender, EventArgs e)
        {
            ListarRegistros();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            ProcesarClave();
        }
    }
}
